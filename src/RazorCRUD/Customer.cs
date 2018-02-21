﻿using System.ComponentModel.DataAnnotations;

namespace RazorCRUD
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Name { get; set; }
    }
}