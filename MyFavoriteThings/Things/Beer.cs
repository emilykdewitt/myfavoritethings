using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Beer
    {
        public decimal ABV { get; set; }

        public string Color { get; set; }

        public bool IsImported { get; set;}

        public void ProduceBurp()
        {
            Console.WriteLine("Brrruuuuppppp. Oof excuse me!");
        }

        public void MakeTipsy()
        {
            Console.WriteLine("Is it just me or is the room spinning?");
        }
    }
}
