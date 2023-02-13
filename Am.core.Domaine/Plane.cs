using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.core.Domaine
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Planeid { get; set; }
        public PlaneType MyPlaneType { get; set; }

        public IList<Flight> Flights { get; set; }

        public Plane() {} // write ctor to generate this constructor

        //TP1.Q8

        public Plane(PlaneType planetype, int capacity, DateTime manufacturdate) 
        { 
            Capacity = capacity; //on peut this. si on a besoin de précision
            ManufactureDate = manufacturdate;
            MyPlaneType = planetype;
        }

        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + Planeid + ";"
                + "PlaneType:" + MyPlaneType;
        }
    }
}
