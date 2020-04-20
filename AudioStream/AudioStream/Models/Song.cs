using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AudioStream.Models
{
    public class Song
    {
        //metadata for songs 
        public int      Id             { get; set; }
        public string   Title          { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate    { get; set; }
        public string   Genre          { get; set; }

        //user email gets stored here
        public string   Artist         { get; set; }

        public string   PathVal        { get; set; }

        //This is the name that gets displayed
        public string  ArtistName      { get; set; }

    }
}

//Make sure to use EntityFrameworkCore\[command] ie 
//                  EntityFrameworkCore\Update-Database
//                  EntityFrameworkCore\Add-Migration migrationName -Context alteredContext
//                      when editing database as both entityframework and entityframeworkcore are installed 
