using System;

namespace Rectangle_Assignment1
{
    class Program1
    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelection = false;

            while (validMenuSelection == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("Invalid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelection = true;
                }
            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string chosenNumber)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {chosenNumber}:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out aNumber);

                if ((result == false) || (aNumber <=0))
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }

                else
                {
                    isValid = true;
                    Console.WriteLine($"Your {chosenNumber} has been changed to: {aNumber}.\n");
                }
            }

            return aNumber;
        }


        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRecSelect = false;
            string RecSelection;
            int selection;

            while (validRecSelect == false)
            {
                Console.WriteLine("Press 1 to Enter the Length and Width of the rectangle\n");
                RecSelection = Console.ReadLine();
                Console.WriteLine();

                if (RecSelection != "1")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(RecSelection) == 1)
                {
                    validRecSelect = true;

                    int Rec_Length;
                    int Rec_Width;

                    Rec_Length = ValidateUserInput("Rec_Length");
                    Rec_Width = ValidateUserInput("Rec_Width");

                    Console.WriteLine("Length and Width is {0} , {1}", Rec_Length,Rec_Width);
                    Console.WriteLine("------------------------>");
                    Rectangle rec = new Rectangle(Rec_Length, Rec_Width);
                    r = rec;
                }
            }


            selection = ValidateMenuSelection();

            while (selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Rectangle Length is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("Rec_Length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Rectangle Width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("Rec_Width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The result is 2 *({r.GetLength()} + {r.GetWidth()}) is: {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The result is {r.GetLength()} * {r.GetWidth()} is: {r.GetArea()}\n");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to perform any other Operation from below menu.....If NO then Press 7 to EXIT or select suitable option");
                selection = ValidateMenuSelection();

            }

        }
    }
}
