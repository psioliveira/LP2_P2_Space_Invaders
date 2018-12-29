using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Invaders
{
    class Program
    {
        //classe principal do jogo
        static void Main(string[] args)
        {
            Console.WindowHeight = 88;
            Console.WindowWidth  = 88;
            string[] lines = File.ReadAllLines(@"C:\Users\pedro\source\repos\LP2_P2_Space_Invaders\LP2_P2_Space_Invaders\space.txt");
            foreach(string s in lines)
            {
                Console.WriteLine(s);
            }
        }
    }
}
