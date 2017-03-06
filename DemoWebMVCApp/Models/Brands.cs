using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebMVCApp.Models
{
    public class Brands
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int ID { get; set; }

        public Brands(string name, string description, int id)
        {
            Name = name;
            Description = description;
            ID = id;
        }

        public Brands()
        {

        }
    }
}