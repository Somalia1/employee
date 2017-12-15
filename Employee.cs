using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agile.Oops
{
    //This is base or superclass
    public class employee
    {
        public int _employeeid=0;
        public string _employeename;
        public int _employeephone;
        public int _age;
        public string _emailadress;
        public string _Gender;
        public string _Dateofbirth;
       // public string _Country;
        public string _companyname;
        public string _department;
        public string _categories;
        public string _type;
        public int _salary;

        //these are methods of this class
        public int EmployeeID
        {
            get { return _employeeid; }
            set
            {
                if (value.Equals(DBNull.Value))
                {
                    throw new Exception("Employee ID cannot be empty");
                }
                else
                {
                    _employeeid = value;
                }
            }
        }
        public string EmployeName
        {
            get { return _employeename; }
            set { _employeename = value; }
        }

        public int employeephone
        {
            get { return _employeephone; }
            set { _employeephone = value; }
        }
       

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string emailadress
        {
            get { return _emailadress; }
            set { _emailadress = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public string Dateofbirth
        {
            get { return _Dateofbirth; }
            set { _Dateofbirth = value; }
        }

        

       
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; }
        }


        public string department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

    }
}
