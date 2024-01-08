namespace OppgaveCodeAlongE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personlist = new List<Person>
            {
            new Person("John Doe", 25, "123 Main St"),
            new Person("Jane Smith", 31, "456 Oak St"),
            new Person("Bob Johnson", 22, "789 Elm St"),
            new Person("Alice Brown", 35, "101 Pine St"),
            new Person("David White", 28, "202 Maple St")
            };
            
            foreach (Person p in Personlist)
            {
                if (p.Age > 30)
                {
                    p.PrintPerson();
                }
            }
            Console.WriteLine();

            bool cont = false;

            Console.WriteLine("Would you like to add a person to the list?");
            var input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "ok" || input == "y")
            {
                cont = true;

                while (cont)
                {
                    AddPerson(Personlist);
                    foreach (Person p in Personlist)
                    {
                        if (p.Age > 30)
                        {
                            p.PrintPerson();
                        }          
                    }
                    cont = false;

                    Console.WriteLine();
                    Console.WriteLine("would you like to add another person to the list?");
                    if (Console.ReadLine().ToLower() == "yes" || Console.ReadLine().ToLower() == "ok" || Console.ReadLine().ToLower() == "y")
                    {
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine("All controll");
                        cont = false; 
                    }

                }
                
            }
            else
            {
                Console.WriteLine("All controll");
            }
        }
        private static void AddPerson(List<Person> Personlist)
        {
            Console.WriteLine("Submit the person's name");
            string name = Console.ReadLine();
            
            Console.WriteLine("Submit the person's age");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please submit an age");
            }
            
            Console.WriteLine("Submit the persons adress");
            string address = Console.ReadLine();

            Person newPerson = new Person (name, age, address);

            Personlist.Add(newPerson); 
        }
       
    }
}