using System;
using System.Collections.Generic;

namespace Business
{
    public class Animal
    {
        public string name { get; set; }
        public Size size { get; set; }
        public FoodType foodType { get; set; }


        public int Getpoints()
        {
            return (int)size;
        }
    }
}
