using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();
            
            // Done - Create a seperate class file called Car
            // Done - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //instantiation 1 - Using dot notation
            var brunosCar = new Car();
            brunosCar.Make = "Ford";
            brunosCar.Model = "Focus";
            brunosCar.Year = 2013;
            brunosCar.EngineNoise = "vroom";
            brunosCar.HonkNoise = "beep";
            brunosCar.IsDriveable = true;

            lot.Cars.Add(brunosCar);

            //instantiation 2 - Object  Initializer Syntax 
            var fernandasCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "vruuuga",
                IsDriveable = false,
            };

            // Add Fernandascar the carlot

            lot.Cars.Add(fernandasCar);

            //instantiation 3 - Using the constructor  to allow parameters values to be placed inside properties
            var gabrielsCar = new Car(2020, "Citroen", "SpaceToureC4", "vrommmm", "vruuuga", true );

            lot.Cars.Add(gabrielsCar);

            // call methods


            brunosCar.MakeEngineNoise();
            fernandasCar.MakeEngineNoise();
            gabrielsCar.MakeEngineNoise();

            //*************BONUS*************//

            // Done - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            // Done - Create a CarLot class
            // Done - It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($" Year: {car.Year} Make: {car.Make} Model: {car.Model} ");
            }

            
        }
    }
}
