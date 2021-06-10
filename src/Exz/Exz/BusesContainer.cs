using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exz
{
    class BusesContainer
    {
        public Bus[] array_Bas;
        public BusesContainer(int size)
        {
            array_Bas = new Bus[size];
        }
        public void SortByWay()
        {
            for(int i=0; i <= array_Bas.Count(); i++)
            {
                for(int j = 0; j <= array_Bas.Count(); i++)
                {
                    if (array_Bas[j].way_Number < array_Bas[j + 1].way_Number)
                    {
                        Bus value = array_Bas[j];
                        array_Bas[j] = array_Bas[j + 1];
                        array_Bas[j + 1] = value;
                    }
                }
            }
        }
    }

}
