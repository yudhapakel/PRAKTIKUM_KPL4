using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD_4
{
    public class FanLaptop
    {
        public enum State {Quiet, Balanced, Peformanced, Turbo }
        static State stateSekarang = State.Quiet;

        public FanLaptop() 
        {
            stateSekarang = State.Quiet;
            Console.WriteLine("fan mode quiet");
        }

        public void Balanced()
        {
            stateSekarang = State.Balanced;
            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
        }

        public void Peformanced() 
        {
            stateSekarang = State.Peformanced;
            Console.WriteLine("Fan Quiet berubah menjadi Peformanced");
        }

        public void Turbo()
        {
            stateSekarang = State.Turbo;
            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
        }
        public static void Main(string[] args)
        {
            FanLaptop fan = new FanLaptop();

            while (true)
            {
                Console.Write("masukan perintah kipas: ");

                string perintah = Console.ReadLine();
                switch (stateSekarang)
                {
                    case State.Balanced:
                        Console.WriteLine("mode up");
                        stateSekarang = State.Balanced;
                        break;
                    case State.Quiet:
                }
            }
        }
    }
}
