﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        [Required]
        public Guid guid { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ClassSubject { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreateUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }
    }
}
