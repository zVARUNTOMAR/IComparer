using System;

namespace ComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            User[] users = new User[4] { new User("Varun", 1998), new User("Ajay", 1977), new User("Atul", 1987),new User("Bob",2020) };

            foreach (User i in users) {
                Console.WriteLine("{0},{1}",i.name,i.dateOfBirth);
            }

            Console.WriteLine("========AFTER SORTING======");

            Array.Sort(users);

            foreach (User i in users) {
                Console.WriteLine("{0},{1}",i.name,i.dateOfBirth);
            }
        }
    }
}
