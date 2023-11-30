using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork11.BuildingCreator
{
    class Creator
    {
        private Creator()
        { }
        public static Building Create()
        {
            Building built = new Building();
            buildings[built.Number] = built;
            return built;
        }
        public static void Delete(int number)
        {
            buildings.Remove(buildings[number]);
        }
        private static Hashtable buildings = new Hashtable();
    }
}
