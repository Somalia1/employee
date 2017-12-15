using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Oops
{
    //this is an encapsulation class
    public class achievementclass
    {
        //these are member variables
        private string _employeename;
        private string _forwardapplication;
        private string _achevmenttitle;
        private string _approval;
        private string _discription;
        private string _note;

        //these are mothods or functions
        public string employeename
        {
            get { return _employeename; }
            set { _employeename = value; }

        }
        public string forwarapp
        {
            get { return _forwardapplication; }
            set { _forwardapplication = value; }
        }
        public string achievmenttitle
        {
            get { return _achevmenttitle; }
            set { _achevmenttitle = value; }
        }

        public string approval
        {
            get { return _approval; }
            set { _approval = value; }
        }

        public string discription
        {
            get { return _discription; }
            set { _discription = value; }
        }
        public string note
        {
            get { return _note; }
            set { _note = value; }
        }

       


    }
}
