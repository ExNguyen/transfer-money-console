using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            List<Person> people = new List<Person>
            {
                new Person("John", 1000),
                new Person("Jane", 500),
                new Person("David", 1500),
                new Person("Virginia", 1000),
                new Person("Tank", 1000)
            };
            //Person person1 = new Person("John", 1000);
            //Person person2 = new Person("Jane", 500);
            //Person person3 = new Person("Ryan", 150);
            //Person person4 = new Person("Virginia", 10000);
            //Person person5 = new Person("Karen", 5126);

            ////TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            //person1.DisplayInfo();
            //person2.DisplayInfo();
            //person3.DisplayInfo();
            //person4.DisplayInfo();
            //person5.DisplayInfo();
            people[0].DisplayInfo();
            people[1].DisplayInfo();
            people[2].DisplayInfo();
            people[3].DisplayInfo();
            people[4].DisplayInfo();
            ////TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            ////TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            Console.WriteLine("Select a sender:");
            for (int i = 0; i < people.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {people[i].name}");
                }
            int sender = int.Parse(Console.ReadLine()) - 1;
            
            Console.WriteLine("Select a recipient:");
            for (int i = 0; i < people.Count; i++)
            {
                if (i != sender)
                {
                    Console.WriteLine($"{i + 1}. {people[i].name}");
                }
            }
             int recipient = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Select an amount to transfer; ");
            int transferAmount = int.Parse(Console.ReadLine());

            people[sender].TransferMoney(people[recipient], transferAmount);
            ////TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            //person1.DisplayInfo();
            //person2.DisplayInfo();
            //person3.DisplayInfo();
            //person4.DisplayInfo();
            //person5.DisplayInfo();
            people[0].DisplayInfo();
            people[1].DisplayInfo();
            people[2].DisplayInfo();
            people[3].DisplayInfo();
            people[4].DisplayInfo();
            Console.WriteLine("Simulation complete.");
        }
    }
}
