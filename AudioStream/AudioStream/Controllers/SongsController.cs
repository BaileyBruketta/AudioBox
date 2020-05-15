using AudioStream.Data;
using AudioStream.Migrations;
using AudioStream.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;


namespace AudioStream.Controllers
{
    public class SongsController : Controller
    {
        private readonly AudioStreamContext _context;

        public SongsController(AudioStreamContext context)
        {
            _context = context;
        }

        // GET: Songs
        //match artists to songs and return a list
        public async Task<IActionResult> Index(string genre, string artistSelection)
        {
            //order songs by date and return 100 newest songs in dB
            var songs = from m in _context.Song
                        select m;
            songs = songs.OrderByDescending(s=>s.ReleaseDate).Take(100);

            //filter by genre
            if(genre != null)
            {
                if (genre != "all")
                {
                    songs = songs.Where(s => s.Genre == genre);
                }
            }

            //filter by artist
            if (artistSelection != null)
            {
                songs = songs.Where(s => s.ArtistName == artistSelection);
                ViewData["ArtistSelection"] = " by " + artistSelection;
            }
            else ViewData["ArtistSelection"] = "";

            ViewData["GenreSelection"]  = genre;
            

            //return songs list to page 
            return View(await songs.ToListAsync());
        }
         
        //Adds a songs to a users list of liked songs, removes songs from dislike list, changes the songs count of likes/dislikes
        public void LikeSong(Song song)
        {
            //WHat will happen is that a songID string will be sent to this fucntion
            //the user model will have a string value with all its liked songs
            //separated by .,.    
            //we will split this string into an array of strings, and then
            //compare to the songid thta has been sent, and use this evaulation to decide if we 
            //add a like to the song and add the somg to the liked list

            //initiate needed variables
            var userid = User.Identity.Name;
            bool check = false;
            var ss3 = song.Id.ToString();

            //grab the user object for the logged in identity
            var user = _context.User.FirstOrDefault(p => p.Email == userid);

            //grabs a reference to the song in the database for editing
            var songToEdit = _context.Song.FirstOrDefault(p => p.Id == song.Id);

            //iterate through songs that the user likes
           // 
           //     var x = user.LikedSongs.Length - 1;
          //      for (int i = 0; i < x; i++)
          //      {
          //          if (user.LikedSongs[i] == ss3)
          //              check = true;
           //         }
          //      }
            
            //if user has not liked the afforementioned song, add the song to the user's list of liked songs 
            //we add one like to the songs like count
            if(check==false)
            {
         //       user.LikedSongs.Append(ss3);
          //      songToEdit.Likes += 1;
            }

            //here we see if the song has previously been in the user's list of disliked songs
            bool check2 = false;
            var numToR = 0;
         //   x = user.DislikedSongs.Length - 1;
          //  for(int i = 0; i < x; i ++)
          //  {
         //       if(user.DislikedSongs[i] == ss3)
         //       {
         //           check2 = true;
          //          numToR = i;
          //      }
          //  }

            //if the song had been previously found in the user's list of disliked songs, we remove it here
            //we also remove "1" from the count of dislikes the song currently holds
            if (check2==true)
         //   {
          //      string[] newArray = new string[0];
          //      for(int i = 0; i < x; i ++)
         //       {
         //           if(i!=numToR)
         //           {
         //               newArray.Append(user.DislikedSongs[i]);
        //            }
         //       }
          //      user.DislikedSongs = newArray;
         //       songToEdit.Dislikes -= 1;
         //       
         //   }


            _context.SaveChanges();

        }

        // GET: Songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // GET: Songs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Artist")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(song);
        }

        // GET: Songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FindAsync(id);
            if (song == null)
            {
                return NotFound();
            }
            return View(song);
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Artist")] Song song)
        {
            if (id != song.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.Id))
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
            return View(song);
        }

        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Song.FindAsync(id);
            _context.Song.Remove(song);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(int id)
        {
            return _context.Song.Any(e => e.Id == id);
        }
    }
}
