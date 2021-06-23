﻿using System;

namespace DatingApp.Dtos
{
    public class LikeDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public string PhotoUrl { get; set; }
        public string City { get; set; }
    }
}
