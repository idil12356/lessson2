using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, Pob, Dob, Email, Status, Sex, tell;
            
            Console.WriteLine("Gali magaca");
            Name = Console.ReadLine();
            Console.WriteLine(Name);

            Console.WriteLine("Gali mesha kudalatay");
            Pob = Console.ReadLine();
            Console.WriteLine(Pob);

            Console.WriteLine("Gali Taariikhda dhalatay");
            Dob = Console.ReadLine();
            Console.WriteLine(Dob);

            Console.WriteLine("Gali Emailkaaga");
            Email = Console.ReadLine();
            Console.WriteLine(Email);

            Console.WriteLine("Gali Statuskaaga");
            Status = Console.ReadLine();
            Console.WriteLine(Status);

            Console.WriteLine("Gali sex gaaga");
            Sex = Console.ReadLine();
            Console.WriteLine(Sex);

            Console.WriteLine("Gali Lambarkaaga");
            tell = Console.ReadLine();
            Console.WriteLine(tell);


            Random Qulxin = new Random();
            int tiro;

            int iskudar = 0;
            int loop;
            for(loop = 1; loop <= 10; loop++)
            {
                tiro = Qulxin.Next(1, 50);
                Console.WriteLine(loop+"\t\t"+tiro);
                iskudar = iskudar + tiro;

            }
            Console.WriteLine("iskudarka waa" + iskudar);
        }
    }
}
