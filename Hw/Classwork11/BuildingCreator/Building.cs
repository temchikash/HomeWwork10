using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork11.BuildingCreator
{
    class Building
    {
        private int number;
        public int Number
        {
            get => number;
            set => number = value;
        }
        private ushort height;
        public ushort Height
        {
            get => height;
            set => height = value;
        }
        private byte number_of_floors;
        public byte Floors
        {
            get => number_of_floors;
            set => number_of_floors = value;
        }
        private ushort number_of_flats;
        public ushort Flats
        {
            get => number_of_flats;
            set => number_of_flats = value;
        }
        private byte number_of_entrances;
        public byte Entrance
        {
            get => number_of_entrances;
            set => number_of_entrances = value;
        }
        static Random r = new Random();
        public static int generic_number = r.Next(1000);
        internal Building(int n, ushort h, byte floors, ushort flats, byte entrances)
        {
            number = n;
            height = h;
            number_of_floors = floors;
            number_of_flats = flats;
            number_of_entrances = entrances;
        }
        internal Building()
        {
            number = generic_number;
            height = 30;
            number_of_floors = 10;
            number_of_entrances = 5;
        }
        public int FloorHeight(ushort h, byte f)
        {
            int temp = h / f;
            return temp;
        }
        public int FlatsInEntrance(ushort f, byte e)
        {
            int temp = f / e;
            return temp;
        }
        public int FlatsOnFloor(ushort flats, byte e, byte floors)
        {
            int temp = (flats / e) / (floors - 1);
            return temp;
        }
    }
}
