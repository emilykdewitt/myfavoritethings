using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Pie
    {
        public string Filling { get; set; }

        public string CrustType { get; set; }

        public bool IsHomemade { get; set; }

        public void DelightEater()
        {
            Console.WriteLine("Ooh la la! This is a tasty pie!");
        }

        public void MakeBakerPopular()
        {
            Console.WriteLine("Pie is the reason I have friends.");
        }
    }
}
