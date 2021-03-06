﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paragraff.Data.Models
{
    public class Book
    {
        public Book()
        {
            this.Wisher = new HashSet<User>();
        }

        public Guid Id { get; set; }
        
        [Index(IsUnique = true)]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
        
        public virtual ICollection<User> Wisher { get; set; }

        [Required]
        public string Author { get; set; }
        
        public DateTime PublishedOn { get; set; }

        /// <summary>
        /// Who published the book
        /// </summary>
        [Required]
        public string Publisher { get; set; }
        
        [Required]
        public byte[] Image { get; set; }
    }
}
