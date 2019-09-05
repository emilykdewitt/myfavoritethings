using MyFavoriteThings.Things;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var destin = new Beach
            {
                SandColor = "white",
                MaxWaveHeight = 2,
                IsPublic = true
            };

            var midget = new Car
            {
                TopSpeed = 90,
                Make = "MG",
                Model = "Midget"
            };

            var gumballhead = new Beer
            {
                ABV = 5.6m,
                Color = "Golden yellow",
                IsImported = false
            };

            var keylimechess = new Pie
            {
                Filling = "Key Lime and Chess Combo",
                CrustType = "Storebought",
                IsHomemade = true,
            };

            destin.CrashWave();

            midget.RevEngine();

            gumballhead.ProduceBurp();

            keylimechess.DelightEater();

        }
    }
}
