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

        public static double CalculateWindowArea(double width, double height, double border)
        {
            double area;
            area = (width - border * 2) * (height - border * 2);
            return area;
        }

        public static double CalculateBorderArea(double width, double height, double border)
        {
            double totarea, area;
            totarea = (width * height);
            area = totarea - CalculateWindowArea(width, height, border);
            return area;
        }
    }
}
