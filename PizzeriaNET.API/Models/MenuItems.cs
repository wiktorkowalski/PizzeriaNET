﻿using Microsoft.AspNetCore.Mvc;

namespace PizzeriaNET.API.Models
{
    public class MenuItems
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
    }
}