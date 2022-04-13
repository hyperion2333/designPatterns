using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public readonly struct DisplayResolution
    {

        public DisplayResolution(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }

        public override string ToString() => $"Resolution: {X}x{Y}";

    }
    public readonly struct Camera
    {
        public Camera(float frontCameraMpx, float backCameraMpx)
        {
            FrontCameraMpx = frontCameraMpx;
            BackCameraMpx = backCameraMpx;
        }
        public float FrontCameraMpx { get; }
        public float BackCameraMpx { get; }
        public override string ToString() => $"FrontCameraMpx: {FrontCameraMpx}mpx, " +
            $"BackCameraMpx: {BackCameraMpx}";
    }
    public readonly struct Display
    {
        public Display(double inch, string type)
        {
            Inch = inch;
            Type = type;
        }
        public double Inch { get; }
        public string Type { get; }
        public override string ToString() => $"DisplayType: {Type}, " +
            $"Inch: {Inch}";
    }
    public class Smartphone
    {
        // private field denoting the type of phone
        private readonly string _phoneBrand;


        public Smartphone(string phoneType)
        {
            this._phoneBrand = phoneType;
        }

        // Properties
        public DisplayResolution Resolution { get; set; }
        public Camera CameraMpx { get; set; }
        public Display Display { get; set; }

        public void Show()
        {
            Console.WriteLine($"Brand Smartphone: {this._phoneBrand}");
            Console.WriteLine(this.Resolution.ToString());
            Console.WriteLine(this.CameraMpx.ToString());
            Console.WriteLine(this.Display.ToString());
        }
    }
}
