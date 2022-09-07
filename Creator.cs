using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Creator
    {
        private static Dictionary<long, Building> _created = new Dictionary<long, Building>();
        private static long currentId = 0L;

        public static Building create(string type)
        {
            Building newBuilding = Parse(type);
            _created.Add(currentId++, newBuilding);
            return newBuilding;
            
        }

        public static void Remove(long id)
        {
            _created.Remove(id);
        }

        private static Building Parse(string type)
        {
            switch (type)
            {
                case ("struct"):
                    return new StructBuilding();
                default:
                    throw new ArgumentException("Invalid argument");
            }
        }
    }
}
