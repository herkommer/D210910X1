using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car myCar;          //Vi berättar att vi från stack tänker anv ett Car Objekt
            myCar = new Car();  //Här hamnar ett unikt objekt i minnet (Heap)

            Console.WriteLine("Type= " + myCar.GetType().ToString());
            Console.WriteLine(myCar.ToString());

            Console.WriteLine("=============");

            
            myCar.Color = "Red";
            myCar.Make = "Volvo";
            myCar.Model = "V70";

            Console.WriteLine(myCar);           //tostring anropas
            Console.WriteLine(myCar.MyData());  //MyData anropas
            Console.WriteLine("=============");

            Car yourCar;
            yourCar = myCar;
            yourCar.Color = "Blue";

            int i = 10;
            int j;
            j = i;
            j = 20;
            Console.WriteLine("i= "+ i);
            Console.WriteLine("j= " + j);

            Console.WriteLine("myCar color: " + myCar.Color);
            Console.WriteLine("yourCar color: " + yourCar.Color);

            Console.WriteLine("=============");

            Console.WriteLine($"Din bil är en {myCar.Color} {myCar.Make} {myCar.Model}.");

            //Car[] Cars = new Car[]... detta orkar vi inte
            //En bättre lösning är att använda List<T>
            //List är en inkapsling av Array och ger som metoder
            //för att manipulera listan enklare
            //Vi kallar det nu för en Collection

            List<Car> MyCars = new List<Car>();
            MyCars.Add(myCar);

            MyCars.Add(new Car() { Color = "Blue", Make = "Tesla", Model = "Plaid" });
            MyCars.Add(new Car() { Color = "Blue", Make = "Audi", Model = "S3" });
            MyCars.Add(new Car());

            Console.WriteLine($"Vi erbjuder idag {MyCars.Count} bilar");

            Console.WriteLine("=================");

            foreach (Car c in MyCars)
            {
                Console.WriteLine($"{c.Color} {c.Make} {c.Model}");
            }

            Console.WriteLine(myCar.Model);
            Console.WriteLine(MyCars[0].Model);

            Console.WriteLine(MyCars[1].Model);

            Console.WriteLine("================");
            Console.WriteLine("List = " + MyCars.GetType());

            //
            Console.WriteLine("Vilken färg har din bil?");
            Car newCar= new Car();
            newCar.Color=Console.ReadLine();
            MyCars.Add(newCar);
            int x = MyCars.Count - 1;
            Console.WriteLine(MyCars[x].Color);
        }
    }

    public class Car
    {
        //Metoder (verb), egenskaper (adjektiv), händelser

        //Properties (egenskaper)
        //public string Color;
        //public string Model;
        //public string Make;

        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        //Jag ändrar hur klassen Car ska agera på ToString metoden
        //det kallas för OVERRIDE
        public override string ToString()
        {
            return $"Jag är en {Color} {Make} {Model}";
        }

        //Egen metod
        public string MyData()
        {
            return $"I am a {Color} {Make} {Model}";
        }

    }
}
