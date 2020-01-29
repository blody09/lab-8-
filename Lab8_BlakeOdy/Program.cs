using System;

namespace Lab8_BlakeOdy
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userChoice = true;
            bool repeat = true;
            int student = 1;


            //string arrays with all fellow students names
            string[] names = { "Sean", "Kyle", "James" };

            // set strings array for hometown
            string[] hometown;
            //create a new string to hold info for 3 student
            hometown = new string[4];

            //create arrays with information about students hometown
            hometown[0] = "Ann Arbor";
            hometown[1] = "Windsor";
            hometown[2] = "Detroit";


            //repeat above for the final arrays of information you want

            string[] food;
            food = new string[4];
            
            food[0] = "Salad";
            food[1] = "Pizza";
            food[2] = "Curry";

            string[] car;
            car = new string[4];

            car[0] = "Toyota Supra";
            car[1] = "Nissan Skyline";
            car[2] = "Nissan GTR";
            



            Console.WriteLine("Welcome to our C# class. Which student would you like to know more about? Enter number 1-3");

            //use while loop to see if user would like to repeat

            while(repeat)
            {
                Console.WriteLine("Class directory:");

                // User a for to make starting number that is displayed "1" and not "0"
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {names[i]}");
                    // this will write as follows to the , assuring that it's 1. person 2.person...not 0.person
                }

                //use another while loop for choice validaiton

                student = RangeCheck(int.Parse(GetUserInput("which class member would you like to learn about. 1,2 or 3?")),1,3);
              

                Console.WriteLine($"Class member {student} is {names[student - 1]}.");
                while(userChoice)
                {

                    string topic = GetUserInput($"What would you like to know about {names[student-1]}. (Hometown, Car, Food?)").ToLower();
                    switch(topic)
                    {
                            case "hometown":
                            Console.WriteLine($"{names[student - 1]} was born in {hometown[student - 1]}.");
                            userChoice = ValidateInput("Would you Like to know more about this student, y/n?");
                            break;

                            case "food":
                            Console.WriteLine($"{names[student - 1]}'s favorite food is {food[student - 1]}. :");
                            userChoice = ValidateInput("Would you like to learn more, y/n?");
                            break;

                            case "car":
                            Console.WriteLine($"{names[student - 1]} drives a {car[student - 1]}. :");
                            userChoice = ValidateInput("Would you like to learn more, y/n?");
                            break;

                        // switch cases to navigate and validate users inputs
                        // default statement so if anything else is besides  whats in the case is entered it prompts them again

                            default:
                            Console.WriteLine("This data doesnt exist for this person. Please enter hometown, car or food  ");
                            break;

                    }

                    userChoice = true;
                    repeat = ValidateInput("Would you like to learn about another student, y/n?");


                }

              


            }




        }

        // user input method 
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }

        //method to validate user input
        public static bool ValidateInput(string message)
        {
            string userInput = GetUserInput(message).ToLower();
            if(userInput == "y")
            {
                return true;
            } 
            else if (userInput == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("invalid input");
                return ValidateInput(message);
            }
        }

        public static int RangeCheck(int number, int lower, int upper)
        {
            if (number >= lower && number <= upper)
            {
                return number;

            }
            else
            {
                Console.WriteLine($"Invalid Input. Input should be between {lower}-{upper}");
                number = int.Parse(Console.ReadLine());
                return RangeCheck(number, lower, upper);
            }
        }


    }
 }

