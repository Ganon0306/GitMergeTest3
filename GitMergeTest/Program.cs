using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMergeTest
{
    public class Program
    {
        // {    2023. 07. 03. Add user input / Beta
        static void Main(string[] args)
        {

            string userInput = string.Empty;
            Console.WriteLine("This program convert Cmto Inch");
            Console.WriteLine("Input Cm value : "); ;
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);
                Ruler ruler = new Ruler(10);
        // }    2023. 07. 03. Add user input / Beta
            ruler.Run();
        }
    }
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

>>>>>>> origin/main
}
