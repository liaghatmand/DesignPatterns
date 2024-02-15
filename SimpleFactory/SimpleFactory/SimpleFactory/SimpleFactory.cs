using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleFactory
{
    public class SimpleFactory
    {
        public static IVehicle Create(string type)
        {
            switch (type)
            {
                case "car":
                    Car car = new();
                    return car;
                case "truck": 
                   Truck truck = new();
                    return truck;
                default:
                    throw new Exception("Wrong user type passed.");
            }
        }
    }

    public interface IVehicle {
        public string Kind();
    }
    public class Car : IVehicle {
        public string Kind()
        {
            return "you made a car!";
        }
    }
    public class Truck : IVehicle {
        public string Kind()
        {
            return "you made a truck!";
        }
    }
}

