using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Oops
{

    //this is polymorphism class
    public class TransferInformation
    {
        public string transferto(string head_office)
        {
            return head_office;
        }

        public string transferto(string head_office, string system_admin)
        {
            return system_admin;
        }
    }
}
