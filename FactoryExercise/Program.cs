using System;

namespace FactoryExercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What database would you like to work with?");
                Console.WriteLine("Type sql");
                Console.WriteLine("Type mongo");
                Console.WriteLine("Type list");

                 userInput = Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input!");
                }
            } while (!correctInput);

            Console.Clear();
            

            IDataAccess data = DataAccessFactory.GetDataAccessType(userInput);

            var products = data.LoadData();
            data.SaveData();

            foreach (var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price:{item.Price}"); 
            }
               
           
        }
    }
}
