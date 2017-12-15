using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Oops
{
    //this is an inheritance class it inherits of base class
    class Fulltime:employee
    {

        //this methods calculates the salary of full time employee
        public double CalculateIncom()
        {
            return (Salary * 12);
        }

    }
}
