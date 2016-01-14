using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class BusinessLogicWindow
    {
        /// <summary>
        /// CalculatePerimeter calculates the perimeter of a window
        /// </summary>
        public static double CalculatePerimeter(double width, double height)
        {
            double perimeter;
            perimeter = width * 2 + height * 2;
            return perimeter;
        }
    }
}
