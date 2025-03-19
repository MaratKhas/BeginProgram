using Coliseum.Interfaces;
using Coliseum.Models;
using System;

namespace Coliseum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IColiseum coliseum = new OneToOneColiseum();
            coliseum.StartFaith();

            Console.ReadKey();
        }
    }
}
