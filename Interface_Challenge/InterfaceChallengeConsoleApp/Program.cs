using System;
using ClassLibraryInterfaceChallenge;

namespace InterfaceChallengeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declorations
            int Ongoing = 1;
            string input = "";
            double sl1 = 0;
            double sl2 = 0;
            double Radius = 0;
            
            Console.WriteLine("what shape do you want to make?");
            Console.WriteLine("A:Square");
            Console.WriteLine("B:Rectangle");
            Console.WriteLine("C:Equilateral Triangle");
            Console.WriteLine("D:Right Angle Triangle");
            Console.WriteLine("E:Circle");
            //First option input
            while(Ongoing == 1)
            {
                try
                {
                    //check to see if input is valid
                    input = Console.ReadLine();
                    if (input == "A")
                    {

                    }
                    else if (input == "B")
                    {

                    }
                    else if (input == "C")
                    {

                    }
                    else if (input == "D")
                    {

                    }
                    else if (input == "E")
                    {

                    }
                    else
                    {
                        throw new NotAnOptionException("not an option");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("the awnser must be one of the options");
                }
                catch (NotAnOptionException e)
                {
                    Console.WriteLine("the awnser must be one of the options");
                }
                if (input == "A")
                {
                    Console.WriteLine("what is your side length?");
                    try
                    {
                        //input of side1
                        sl1 = double.Parse(Console.ReadLine());
                        if ((sl1 % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannot be decimal");
                    }
                    //creation of Square
                    new Square(sl1);
                    Console.WriteLine("square created");
                }
                else if (input == "B")
                {
                    Console.WriteLine("what is your First side length?");
                    try
                    {
                        //input of side1
                        sl1 = int.Parse(Console.ReadLine());
                        if ((sl1 % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannot be decimal");
                    }
                    Console.WriteLine("what is your First side length?");
                    try
                    {
                        //input of side2
                        sl2 = int.Parse(Console.ReadLine());
                        if ((sl2 % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannot be decimal");
                    }
                    //creation of rectangle
                    new Rectangle(sl1, sl2);
                    Console.WriteLine("rectangle created");
                }
                else if (input == "C")
                {
                    Console.WriteLine("what is your side length?");
                    try
                    {
                        //input of side1
                        sl1 = int.Parse(Console.ReadLine());
                        if ((sl1 % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannot be decimal");
                    }
                    //creation of Equilateral
                    new Equllateral(sl1);
                    Console.WriteLine("Equllateral Triangle Created");
                }
                else if (input == "D")
                {
                    Console.WriteLine("what is your First side length?");
                    try
                    {
                        //input of side1
                        sl1 = int.Parse(Console.ReadLine());
                        if ((sl1 % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannot be decimal");
                    }
                    Console.WriteLine("what is your First side length?");
                    try
                    {
                        //input of side2
                        sl2 = int.Parse(Console.ReadLine());
                        if ((sl2 % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannotbe decimal");
                    }
                    //creation of Right Angle
                    new RightAngle(sl1, sl2);
                    Console.WriteLine("Right Angle Triangle Created");
                }
                else if (input == "E")
                {
                    Console.WriteLine("what is your Radius?");
                    try
                    {
                        Radius = int.Parse(Console.ReadLine());
                        if ((Radius % 1) > 0)
                        {
                            throw new DecimalException("number is decimal");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("the awnser must be a number");
                    }
                    catch (DecimalException e)
                    {
                        Console.WriteLine("number cannot be decimal");
                    }
                    //creation of Circle
                    new Circle(Radius);
                    Console.WriteLine("Circle Created");
                }
                Console.ReadKey();
                Console.WriteLine("would you like to keep going");
                Console.WriteLine("Write no to stop");
                input = Console.ReadLine();
                if (input == "no")
                {
                    Ongoing = 0;
                }
            
            }
        }
    }
}
