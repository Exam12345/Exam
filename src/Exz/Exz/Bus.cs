using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Bus
    {
        private int way_Number { get; set; }
        private string end_Station_1 { get; set; }
        private string end_Station_2 { get; set; }
        private int station_Count { get; set; }

        public Bus(int way_Number, string end_Station_1, string end_Station_2, int station_Count)
        {
            this.way_Number = way_Number;
            this.end_Station_1 = end_Station_1;
            this.end_Station_2 = end_Station_2;
            this.station_Count = station_Count;
        }
        public Bus()
        {

        }
        
    }
}
