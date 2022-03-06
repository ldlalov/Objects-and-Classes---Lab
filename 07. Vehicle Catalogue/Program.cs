using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }
    internal class Vehicle
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {

                string[] cmd = input.Split('/');
                string type = cmd[0];
                string brand = cmd[1];
                string model = cmd[2];
                if (type == "Car")
                {
                    double horsePower = int.Parse(cmd[3]);
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    cars.Add(car);
                }

                else
                {
                    double weight = int.Parse(cmd[3]);

                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    trucks.Add(truck);
                }
            }
            List<Car> orderedCars = cars.OrderBy(car => car.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (Car car in orderedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            List<Truck> orderedTrucks = trucks.OrderBy(trucks => trucks.Brand).ToList();
            Console.WriteLine("Trucks:");
            foreach (Truck truck in orderedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

    }
}
