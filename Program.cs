using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ArrayProject_II {
    internal class Program {
        static void Main(string[] args) {

            int indexer = 0;
            PrintColor("---Enter The Contact's Name You Are Searching For---", ConsoleColor.Cyan);
            Console.WriteLine();


            string[] people = { "Nick", "Tyler", "Breland", "Ashlyn", "Alexis", "Ellie", "Takera", };
            string[] phoneNumbers = { "(123)456-7890", "(234)567-8901", "(345)678-9012", "(456)789-0123", "(567)890-1234", "(678)901-2345", "(789)012-3456" };
            string search = Input("Contact Name? ");
            Console.WriteLine(ContactSearch(people, search));

            for (int index = 0; index < people.GetLength(0); index += 1) {

                if (search == people[index])
                    indexer = index;
                
            }//end for

            if (search != people[indexer]) {
                Console.WriteLine("Please Try Again");
            } else {
                Console.WriteLine(phoneNumbers[indexer]);
            }//end if



        }//end main

        static string ContactSearch(string[] contact, string target) {

            for (int index = 0; index < contact.GetLength(0); index += 1) {
                if (contact[index] == target) {
                    return ($"{target}'s listed number is: ");
                }//end if
            }//end for
            return "No Contact Exist with that name.";
        }//end function


        #region HELPER FUNCTIONS
        static void Print(string message) {
            Console.Write(message);
        }//end function
        static void PrintColor(string message, ConsoleColor color = ConsoleColor.White) {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }//end function
        static string Input(string message) {
            Console.WriteLine(message);
            return Console.ReadLine();
        }//end function
        static decimal InputDecimal(string message) {
            string value = Input(message);
            return decimal.Parse(value);
        }//end function
        static decimal TryInputDecimal(string message) {
            decimal parsedValue = 0;
            bool parsedSuccessfully = false;

            do {
                parsedSuccessfully = decimal.TryParse(Input(message), out parsedValue);
            } while (parsedSuccessfully == false);
            return parsedValue;
        }//end function
        static double InputDouble(string message) {
            string value = Input(message);
            return double.Parse(value);
        }//end function
        static double TryInputDouble(string message) {
            double parsedValue = 0;
            bool parsedSuccessfully = false;

            do {
                parsedSuccessfully = double.TryParse(Input(message), out parsedValue);
            } while (parsedSuccessfully == false);
            return parsedValue;
        }//end function
        static int InputInt(string message) {
            string value = Input(message);
            return int.Parse(value);
        }//end function
        static int TryInputInt(string message) {
            int parsedValue = 0;
            bool parsedSuccessfully = false;

            do {
                parsedSuccessfully = int.TryParse(Input(message), out parsedValue);
            } while (parsedSuccessfully == false);
            return parsedValue;
        }//end function
        #endregion
    }//end class
}//end namespace