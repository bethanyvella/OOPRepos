using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    //acccess modifier - are the level of access to the class and its members
  public  class Circle

    {
        double radius;

        //constructor -  bears the same name as the class, which is used to create an instance of a class (the object)
        //secondary objective of a constarct : it can be used as a normal method

        // the construct is like the key to start the class / the key to initialized the object

       /* public Circle(double radius, string colour)
        {
            Radius = radius; //setting the defult value
            Colour = colour;
        }*/
        public double Radius { get; set; } //property
        public double Colour { get; set; } //property

        ///<summary>
        /// displays the radius value of the instance when called
        /// </summary>
        ///<returns></returns>

        public string GetRadius()
        {
            return "Radius: " + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
