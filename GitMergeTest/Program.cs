using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMergeTest
{
<<<<<<< HEAD
    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }
=======
    //바꿈
>>>>>>> Alpha
    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }

            //{2023. 07. 03.        Add private _SetInch function / Gamma
            private set { this._setInch(value); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }
        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm는 {this.Inch}inch 입니다.");
        }
        private void _setInch(float inchValue) {  Centimeter = (int)(inchValue / ONE_INCH); }
        //{2023. 07. 03.        Add private _SetInch function / Gamma
    }
<<<<<<< HEAD
=======
    //바꿈
    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }
>>>>>>> Alpha

}
