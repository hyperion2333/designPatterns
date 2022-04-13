using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class SamsungS20Builder : ISmartphoneBuilder
    {
        private readonly Smartphone _phone;
        public SamsungS20Builder()
        {
            this._phone = new Smartphone("Samsung S20");
        }
        public Smartphone Build()
        {
            return this._phone;
        }
        public void BuildResolution()
        {
            this._phone.Resolution = new DisplayResolution(1440, 3200);
        }
        public void BuildDisplay()
        {
            this._phone.Display = new Display(6.2, "AMOLED");
        }

        public void BuildCameraMpx()
        {
            this._phone.CameraMpx = new Camera(10, 12);
        }
    }
}
