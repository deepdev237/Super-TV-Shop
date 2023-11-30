using System;
using System.Collections.Generic;

namespace TV_Shop
{
    struct Agent
    {
        public string name;
        public int call_num;

        public Agent(string name, int call_num) : this()
        {
            this.name = name;
            this.call_num = call_num;
        }
    }

    class Program
    {
        public static List<Agent> agents = new List<Agent>();

        static int Rnd()
        {
            Random rnd = new Random();
            int rand = rnd.Next(20000, 50001);
            return (rand);
        }

        static void Main(string[] args)
        {
            int agent_count;
            while (true)
            {
                Console.Write("Mennyi agent: ");
                string i = Console.ReadLine();
                bool res = int.TryParse(i, out agent_count);
                if (res)
                {
                    break;
                }
            }

            for (int i = 0; i < agent_count; i++)
            {
                Console.Write("Agent neve: ");
                string name = Console.ReadLine();
                int number = Rnd();

                agents.Add(new Agent(name, number));
            }

            Console.WriteLine("1. Alap\n2. Közép\n3. Emelt\n");
            Console.Write("Választás: ");
            int option;

            while (true)
            {
                string i = Console.ReadLine();
                bool res = int.TryParse(i, out option);
                if (res)
                {
                    break;
                }
            }

            int filtered_count = 0;

            switch (option)
            {
                case 1: //Alap
                    foreach (var agent in agents)
                    {
                        if (agent.call_num <= 30000)
                        {
                            Console.WriteLine($"{agent.name}");
                            filtered_count++;
                        }
                    }
                    break;
                case 2: //Közép
                    foreach (var agent in agents)
                    {
                        if (agent.call_num > 30000 & agent.call_num <= 40000)
                        {
                            Console.WriteLine($"{agent.name}");
                            filtered_count++;
                        }
                    } break;
                case 3: //Emelt
                    foreach (var agent in agents)
                    {
                        if (agent.call_num > 40000)
                        {
                            Console.WriteLine($"{agent.name}");
                            filtered_count++;
                        }
                    }
                    break;
            }

            if (filtered_count == 0)
            {
                Console.WriteLine("Nincs ilyen minositessel agent.");
            }
        }
    }
}
