using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Oops
{
   
//this is an abstraction class

 public class promotioninfo
    {
       //these are class members

        private double _oldsalary;
        private double _rate=2;


     //methods of the class 
        public double oldsalary
        {
            get { return _oldsalary; }
            set { _oldsalary= value; }
        }
        private double rate
        {
            get { return _rate; }
            set { _rate= value; }
        }
     //this method calculates the current salary of the employee
        public double calculatecurrentsalary()
        {
            return _oldsalary * _rate;
        }

    }

}
