﻿using System;

namespace Template.CleanArchitecture.Core.Entities
{
    public class ProductEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
