using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeeNote.Models{
    public class Note
    {
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteText { get; set; }
        public string Tag { get; set; }

        public Note()
        {

        }
    }
}