using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public interface ISmartphoneBuilder
    {
        Smartphone Build();
        void BuildResolution();
        void BuildDisplay();
        void BuildCameraMpx();

    }
}
