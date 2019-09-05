using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Car
    {
        public int TopSpeed { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public void RevEngine()
        {
            Console.WriteLine("Vroom vrooooom");
        }

        public void SlamOnBrakes()
        {
            Console.WriteLine("Skkkrrrrrrtttt");
        }
    }
}
