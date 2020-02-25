using System;
using System.Text;

namespace Assessment
{
    public class Building
    {
        StringBuilder stringBuilder = new StringBuilder();
        public Building AddBalcony()
        {
            Building building = BuildingSingleton.Instance;
            stringBuilder.Append("balcony, ");
            return building;
        }

        public Building AddBedroom(string type)
        {
            Building building = BuildingSingleton.Instance;
            stringBuilder.Append($"{type} room, ");
            return building;
        }

        public Building AddKitchen()
        {
            Building building = BuildingSingleton.Instance;
            building.stringBuilder.Append("kitchen, ");
            return building;
        }

        public Building Build()
        {
            Building building = BuildingSingleton.Instance;
            building.stringBuilder.ToString();
            return building;
        }

        public string Describe()
        {
            return stringBuilder.ToString();
        }
    }
}