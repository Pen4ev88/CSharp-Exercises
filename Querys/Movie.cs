﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Querys
{
    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        int _year;
        public int Year
        {
            get
            {
                //throw new Exception("Error!");
                Console.WriteLine($"Returning {_year} for {Title}");
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
}
