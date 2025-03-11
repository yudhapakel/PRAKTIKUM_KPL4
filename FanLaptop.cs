using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD_4
{
    internal class FanLaptop
    {
        private enum State {Quiet, Balanced, Peformanced, Turbo }
        private State stateSekarang;

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
    }
}
