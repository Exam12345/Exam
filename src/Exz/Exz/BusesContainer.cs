using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Exz
{
    class BusesContainer
    {
        public Bus[] array_Bas;
        public Bus bus;
        public BusesContainer(int size)
        {
            array_Bas = new Bus[size];
        }
        public void Sort()
        {
            this.array_Bas = array_Bas.OrderByDescending(bus => bus.way_Number).ThenByDescending(bus => bus.station_Count).ToArray();
        }
        public void SaveToFile()
        {
            this.Sort();
            string filename = "результат.txt";
            string text="";
            for(int i = 0; i < array_Bas.Count(); i++)
            {
                text += String.Format("Номер маршрута:{0},Последняя остановка #1:{1},Последняя остановка #2:{2},Количество остановок:{3}",
                    array_Bas[i].way_Number, array_Bas[i].end_Station_1, array_Bas[i].end_Station_2, array_Bas[i].station_Count)+"\n";
            }
            System.IO.File.WriteAllText(filename, text);
            Process.Start("результат.txt");
        }
    }

}
