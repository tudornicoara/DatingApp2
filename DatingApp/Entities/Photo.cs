using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public bool IsApproved { get; set; } = false;
        public string PublicId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid AppUserId { get; set; }
    }
}
