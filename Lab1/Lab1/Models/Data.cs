﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.Models;
using huffman_prueba;

namespace Lab1.Models
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }

        }

        public int Size = 0;
        public List<Peliculas> RecorridosInorden = new List<Peliculas>();
        public List<Peliculas> RecorridosPostorden = new List<Peliculas>();
        public List<Peliculas> RecorridosPreorden = new List<Peliculas>();
        public Huffman<char> huffman = new Huffman<char>("");


    }
}