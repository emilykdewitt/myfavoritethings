using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Beach
    {
        public string SandColor { get; set; }

        public int MaxWaveHeight { get; set; }

        public bool IsPublic { get; set; }

        public void BlowSand()
        {
            Console.WriteLine("Argh! My eyes!");
        }

        public void CrashWave()
        {
            Console.WriteLine("WHOOOOOSSSSHHHHHHH");
        }
    }
}
