using System;
using System.Collections.Generic;
using System.Text;

namespace CakesMarket.Models.VIewModel
{
    public class CakeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public string Categoty { get; set; }
        public string Ingredients { get; set; }
    }
}
