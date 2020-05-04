using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AudioStream.Models
{
    public class User
    {
        public int Id               { get; set; }
        public string Name          { get; set; }

        public string Email         { get; set; }
        public string Password      { get; set; }
        public bool ArtistAccount   { get; set; }

        public string bio           { get; set; }

        public int numberOfSongs    { get; set; }

        public string primarygenre  { get; set; }

        public Song[] LikedSongs    { get; set; }

        public Song[] DislikedSongs { get; set; }

      


    }
}

//Make sure to use EntityFrameworkCore\[command] ie 
//                  EntityFrameworkCore\Update-Database
//                  EntityFrameworkCore\Add-Migration migrationName -Context alteredContext
//                      when editing database as both entityframework and entityframeworkcore are installed 