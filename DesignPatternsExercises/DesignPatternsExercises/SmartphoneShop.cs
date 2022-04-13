using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class SmartphoneShop
    {

        public SmartphoneShop() { }

        public Smartphone Construct(ISmartphoneBuilder smartphone)
        {
            smartphone.BuildResolution();
            smartphone.BuildDisplay();
            smartphone.BuildCameraMpx();
            return smartphone.Build();
        }
        
    }
}
