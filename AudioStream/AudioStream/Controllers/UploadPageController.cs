using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AudioStream.Data;
using AudioStream.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using AudioStream.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Server;


namespace AudioStream.Controllers
{
    public class UploadPageController : Controller
    {
        //                /                      /          2 variables and a constructor used to set reference to SQLDB and fileserver
        private readonly AudioStreamContext  _context;
        private readonly AudioStream2Context _DbContext;
        private IHostingEnvironment _env;
        public UploadPageController(IHostingEnvironment env, AudioStreamContext context, AudioStream2Context contez)
        {
            _env       = env    ;
            _context   = context;
            _DbContext = contez;
        }
        //            /                   /                    /                /                        /                            /
        public IActionResult Index()
        {
            var userid = User.Identity.Name;
            var user = _context.User.FirstOrDefault(p => p.Email == userid);


            return View(user);
        }
        //User edits bio
        public async Task<IActionResult> BioEdit(string bio)
        {
            var userid = User.Identity.Name;
            var user = _context.User.FirstOrDefault(p => p.Email == userid);
            //user       = user.Where(s => s.Email == userid);
            user.bio = bio;
             _context.SaveChanges();

            return RedirectToAction("Index");


        }

        //User chooses file and fills out details 
        public async Task<IActionResult> FileUpload(IFormFile file, string songName, string Genre)
        {
            //create file path / store file path
            string fileName = songName + ".mp3"          ;     
            var    dir      = _env.WebRootPath           ;
            var    fullpath = Path.Combine(dir, fileName);

            //Add uplaoded file to file base     / saves files to server with precreated filepath name 
            using (var fileStream = new FileStream(Path.Combine(dir, fileName), FileMode.Create, FileAccess.Write))
            {   file.CopyTo(fileStream);    }

            //Retreive user details from identity/ current user id / authenticated session /    /    /     /    /    
            var    userid        = User.Identity.Name   ;    // retreieve session ID
            var    date          = DateTime.Now         ;    // retreive  date
            string artistNameStr = ""                   ;    // create empty string field
            var    uses          = _context.User        ;    // begin user iteration
            foreach (User d in uses)
            {
                if(d.Email == userid)
                {
                    artistNameStr = d.Name;                  // set artist name to string field 
                }
            }
            //            /             /              /               /             /           /          /      /

            //This creates an instance of our song model, stores it as a variable, and saves it into the database  /           /          / 
            //       /             /           pass previously generated values to song constructor           /           /          /           /
            var   song   = new Song {ArtistName=artistNameStr, Artist = userid, Genre = Genre, PathVal = fullpath, ReleaseDate = date, Title = songName };
                  _context.Add(song);              
            await _context.SaveChangesAsync();
            
            ////////////////////////////////////////////////////////////////
            ///TODO : add a "successfully uploaded song" blurb ////////////
            ///////////////////////////////////////////////////////////////  
            ///return to index page          
            return RedirectToAction("Index");
            ////////////////////////////////////////////////////////////////
        }
    }
}