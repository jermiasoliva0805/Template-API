using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public abstract void EmitirSonido();
    }

    public class Vaca : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("Muuu");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal a = new Vaca();
            a.EmitirSonido();
        }
    }


}
