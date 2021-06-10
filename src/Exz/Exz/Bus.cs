using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exz
{
    class Bus
    {
        public int way_Number { get; set; }
        public string end_Station_1 { get; set; }
        public string end_Station_2 { get; set; }
        public int station_Count { get; set; }

        public Bus(int way_Number, string end_Station_1, string end_Station_2, int station_Count)
        {
            this.way_Number = way_Number;
            this.end_Station_1 = end_Station_1;
            this.end_Station_2 = end_Station_2;
            this.station_Count = station_Count;
        }
    }
}
