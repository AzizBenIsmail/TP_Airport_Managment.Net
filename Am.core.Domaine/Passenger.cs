using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Am.core.Domaine
{
    internal class Passenger
    {
        public int BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAdresse { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public IList<Passenger> passengers { get; set; }

        public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";"
                + "PassportNumber:" + PassportNumber + ";"
                + "EmailAdresse:" + EmailAdresse + ";"
                + "FirstName:" + FirstName + ";"
                + "LastName:" + LastName + ";"
                + "TelNumber:" + TelNumber + ";"
                + "TelNumber:" + TelNumber;
        }
    }
}
