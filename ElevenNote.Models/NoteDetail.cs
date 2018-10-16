using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevenNote.Models
{
    public class NoteDetail
    {
        public class NoteDetail
        {
            public int NoteId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTimeOffset CreatedUtc { get; set; }
            public DateTimeOffset? ModifiedUtc { get; set; }
            public override string ToString() => $"[{NoteId}] {Title}";

            [Display(Name = "Created")]
            public DateTimeOffset CreatedUtc { get; set; }

            [Display(Name = "Modified")]
            public DateTimeOffset? ModifiedUtc { get; set; }
        }
    }
}
