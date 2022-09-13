internal class Program
{
    private static void Main(string[] args)
    {




        Console.ReadKey();
    }
}

/*
        Variables
        int age;
        age = 23;
        double price = 15.25;
        Boolean isTrue = false;
        char symbol = 'A';

        const double pi = 3.14;


        Console.WriteLine("Your symbols is {0}",symbol);


        if (isTrue)
        {
            Console.WriteLine("The value is {0}", isTrue);
        }
        else
        {
            Console.WriteLine("The value is {0}", isTrue);
        }


        Console.WriteLine("My age is {0}",age);
        Console.WriteLine("The price of the product is {0}", price);
*/

/*
 * Cast Variables
        int a = 364;
        double b = Convert.ToDouble(a);
        String a = "true";
        bool a2 = Convert.ToBoolean(a);



        Console.WriteLine(a2);
        Console.WriteLine(b.GetType());
        Console.WriteLine(a.GetType());
*/

/*
 Inputs C#
            Console.WriteLine("Insert your name...");
            String name = Console.ReadLine();

            Console.WriteLine("Insert your age...");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0}, and you are {1} years old", name, age);
*/

/*
 * 
 * if and else
         Console.WriteLine("Enter a number");
        int number = Console.Read();

        if (number %2 == 0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }

*/


/*
 Switch case


        string dinner = "pizza";

        switch (dinner.ToLower())
        {
            case "hamburger":
                Console.WriteLine(dinner);
                break;
            case "pizza":
                Console.WriteLine(dinner);
                break;
            case "pasta":
                Console.WriteLine(dinner);
                break;
            case "sushi":
                Console.WriteLine(dinner);
                break;
            case "salad":
                Console.WriteLine(dinner);
                break;
            case "nothing":
                Console.WriteLine(dinner);
                break;
            default:
                Console.WriteLine("Somenthing else");
                break;

        }
*/

/*While Loops
        int index = 1;

        while (index <= 100)
        {
            if (index %3 ==0 && index %5 ==0)
            {
                Console.WriteLine("FizzBuzz");
            }else if (index % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(index % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(index);
            }
            
            index++;
        } 
*/

/*
 For loop

        for(int i = 1; i<=50; i++)
        {
            if(i%3==0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }else if (i%3==0)
            {
                Console.WriteLine("Fizz");
            }else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
            
        }

 */

/*Nested Loops
 
        // nested loops = loops inside of other loops
        //                Uses vary. Used a lot in sorting algorithms

        Console.Write("How many rows?: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many columns?: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.Write("What symbol: ");
        String symbol = Console.ReadLine();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

 */

/*Rock Paper Scicors
  Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                
            }

            Console.WriteLine("Thanks for playing!");
 */

/*Calculator
 *      do
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.Write("Enter an option: ");


            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("That was not a valid option");
                    break;
            }
            Console.Write("Would you like to continue? (Y = yes, N = No): ");
        } while (Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine("Bye!");
 */

/*Arrays
// array = a variable that can store multiple values. fixed size

            //String[] cars = {"BMW", "Mustang", "Corvette"};

            String[] cars = new string[3];

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }*/

/*Foreach
           // foreach loop = a simpler way to iterate over an array, but it's less flexible

            String[] cars = {"BMW", "Mustang", "Corvette"};

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
 */

/*
             // method  = performs a section of code, whenever it's called "invoked".
            //           benefit = Let's us reuse code w/o writing it multiple times
            //           Good practice is to capitalize method names (I forgot in this video)

            String name = "Bro";
            int age = 21;

            SingHappyBirthday(name, age);

            Console.ReadKey();
        }
        static void SingHappyBirthday(String birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }*/

/*
 // return  = returns data back to the place where a method is invoked

            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

            Console.ReadKey();
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }*/

/*
  // method overloading  = methods share same name, but different parameters
            //                       name + parameters = signature
            //                       methods must have a unique signature

            double total;
            
            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {      
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
 */

/*
   //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
 */

/*
 // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
 */

/*
 // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);
 */

/*
 *            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders


         string name = "Carlos";
        int age = 23;

        Console.WriteLine($"Your name is {name} and your age is : {age}");
*/

/*
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                                   { "Corvette", "Camaro", "Silverado" }, 
                                                   { "Corolla", "Camry", "Rav4" } 
                                                 };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
           
for (int i = 0; i < parkingLot.GetLength(0); i++)
{
    for (int j = 0; j < parkingLot.GetLength(1); j++)
    {
        Console.Write(parkingLot[i, j] + " ");
    }
    Console.WriteLine();
}
*/

/*
            // class = A bundle of related code.
            //              Can be used as a blueprint to create objects (OOP)
            
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
    static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting");
        }
    }
 */

/*
  // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
 */

/*
 
           // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
 */

/*
 // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
 */
/*
 // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Console.ReadKey();
        }   
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
 */

/*
// inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

Console.WriteLine(car.speed);
Console.WriteLine(car.wheels);
car.go();

Console.WriteLine(bicycle.speed);
Console.WriteLine(bicycle.wheels);
bicycle.go();

Console.WriteLine(boat.speed);
 Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
        }   
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
 */

/*
 // abstract classes =  modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); //can't create a vehicle object


            Console.ReadKey();
        }   
    }
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
 */

/*
Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

foreach (Car car in garage)
{
    Console.WriteLine(car.model);
}

Console.ReadKey();
}   
}
class Car 
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
*/
/*
  Car car1 = new Car("Mustang","red");

            Car car2 = Copy(car1);

            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car 
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
 */

/*
//method overriding = provides a new version of a method inherited from a parent class
//                    inherited method must be: abstract, virtual, or already overriden
//                    Used with ToString(), polymorphism 

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }
    class Animal 
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {

    }
 */
/*
   //ToString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {       
            return "This is a " + make + " " + model;
        }
    }
 */
/*
            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
           
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public virtual void Go()
        {

        }
    }
    class Car: Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
 */

/*
  // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        } 
 */

/*
    // List = data structure that represents a list of objects that can be accessed by index.
    //        Similar to array, but can dynamically increase/decrease in size 
    //        using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //Console.WriteLine(food[0]);
            //Console.WriteLine(food[1]);
            //Console.WriteLine(food[2]);
            //Console.WriteLine(food[3]);

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
 */
/*
 //getters & setters = add security to fields by encapsulation
 //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)
            
            Car car = new Car(400);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }   
    }
    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set                   
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
 */
/*
// enums = special "class" that contains a set of named integer constants.
//         Use enums when you have values that you know will not change,
//         To get the integer value from an item, you must explicitly convert to an int
//         name = integer

            //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius +"km");
            Console.WriteLine("volume: " + volume +"km^3");

            Console.ReadKey();
        }
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum Planets
    {
        Mercury = 1, 
        Venus = 2, 
        Earth = 3, 
        Mars = 4, 
        Jupiter = 5, 
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8, 
        Pluto = 9
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
 */
/*
 // generic =  "not specific to a particular data type"
            //            add <T> to: classes, methods, fields, etc.
            //            allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }     
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
 */
/*
// thread = an execution path of a program
//          We can use multiple threads to perform,
//          different tasks of our program at the same time.
//          Current thread running is "main" thread
//          using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is complete!");

            Console.ReadKey();
        }  
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
 */

