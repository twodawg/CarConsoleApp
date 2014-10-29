using CarConsoleApp.Models;
using CarConsoleApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp.Controllers
{
    class CarControllers
    {
        public CarControllers()
        {
            Console.WriteLine("Hello User, I will create a car for you!");

            Car rentalCar = new Car("Model T", 2);

            CarViewModel carviewmodel = new CarViewModel(rentalCar);

            CarView carview = new CarView(carviewmodel);

            Console.WriteLine(carview);


            rentalCar.Passengers.Add("Bob");
            rentalCar.Passengers.Add("Sherry");

            Console.WriteLine(carview);

            rentalCar = new Car("Tesla", 4);
            carviewmodel = new CarViewModel(rentalCar);
            carview = new CarView(carviewmodel);


            Console.WriteLine(carview);

            //Console.WriteLine("Here you go, a new " + rentalCar.Doors + "-door " +
            //    rentalCar.Model);
            //Console.ReadLine();
            //rentalCar.Passengers.Add("Bob");
            //rentalCar.Passengers.Add("Sherry"); 

            //Console.WriteLine("Whoops, looks like there are people already in it." +
            //    " Do you want to remove them? (Y/N)");

            //string answer = Console.ReadLine();

            //if (answer.ToUpper() == "Y")
            //{
            //    rentalCar.Passengers.Clear();
            //}

            //Console.WriteLine("Ok. Your car is ready! It contains " +
            //    rentalCar.Passengers.Count + " passengers.");
            Console.ReadLine();
        }
    }
}
