﻿using System.ComponentModel.DataAnnotations;

namespace PlatformService.DTOs
{
    public class PlatformWriteDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}