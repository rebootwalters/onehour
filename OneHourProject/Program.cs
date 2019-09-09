using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeaningfulCalculation;

namespace OneHourProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight k1 = new Knight() { Con = 80, Dex = 80, Pre = 80, Str = 80 };
            Knight k2 = new Knight() { Con = 80, Dex = 80, Pre = 80 ,Str = 80 }; 
            MeaningFull mc = new MeaningFull(k1,k2);
            var ans = mc.Joust();
            Console.WriteLine(ans);


        }
    }
}
