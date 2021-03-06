﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AudioStream.Data;
using AudioStream.Models;
using Microsoft.AspNetCore.Identity;

namespace AudioStream.Controllers
{
    public class UsersController : Controller
    {
        private readonly AudioStreamContext _context;

        public UsersController(AudioStreamContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index(string searchString)
        {
            var users = from m in _context.User
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.Name.Contains(searchString));
                //users = users.Where(s => s.ArtistAccount == true);
            }

            else if (String.IsNullOrEmpty(searchString))
            {
               // users = users.Where(s => s.ArtistAccount == true);
            }

            //return View(await _context.User.ToListAsync());
            return View(await users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // /           /               /                 /                 /    This displays an artists profile, can be called from Artists tab or profile button / / /
        // GET: Users/externalProfile/5
        public async Task<IActionResult> externalProfile(int? id)
        {
            //retreive user
            if (id   == null)   { return NotFound(); }
            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)   { return NotFound(); }

            ViewData["ArtistName"] = user.Name                  ; //send the artists name to the viewdata for access on view layer
            ViewData["ArtistBio"]  = user.bio                   ; //send the artists bio to the viewdata for access on view layer

            //retreive one users songs
            var songs = from m in _context.Song select m        ; //get all songs
            songs     = songs.Where(s => s.Artist == user.Email); //select songs by the artist
            
            return View(songs)                                  ; //relay view with selected songs : viewdata with artist name and list of artist sonsg
        }

        //This is used to send the user to their public facing profile via the profile button in the login partial view / nav bar    /        /       /         /   /
        public async Task<IActionResult> redirectToProfile(IdentityUser? l)
        {
            var usercheck = from m in _context.User select m              ; //pull up list of user profiles
                usercheck = usercheck.Where(s => s.Email == l.Id)         ; //select user with email matching the email of the user identity that called this action      
            User x        = usercheck.FirstOrDefault()                    ; //assign the queried user to an user object for temporary reference
            var idNumber  = x.Id                                          ; //retreive the id number of the user

            return RedirectToAction("externalProfile", new {id= idNumber}); //pass the id number to the external profile function to view their public facing profile
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Password,ArtistAccount")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Password,ArtistAccount")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
