using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class IPhoneSEBuilder : ISmartphoneBuilder
    {
        private readonly Smartphone _phone;

        public IPhoneSEBuilder()
        {
            this._phone = new Smartphone("iPhone SE 2020");
        }

        public Smartphone Build()
        {
            return this._phone;
        }

        public void BuildResolution()
        {
            this._phone.Resolution = new DisplayResolution(750, 1334);
        }
        public void BuildDisplay()
        {
            this._phone.Display = new Display((double)4.7 ,"LCD");
        }

        public void BuildCameraMpx()
        {
            this._phone.CameraMpx = new Camera(8, 12);
        }

    }
}
