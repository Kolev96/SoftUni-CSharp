using System;
using System.Collections.Generic;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();
                var actions = commands[0];
                var userName = commands[1];

                switch (actions)
                {
                    case "register":
                        var plateNumber = commands[2];
                        if (CheckIfUserNameNotExist(users, userName))
                        {
                            users.Add(userName, plateNumber);
                            PrintResult($"{userName} registered {plateNumber} successfully");
                        }
                        else
                        {
                            PrintResult($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (CheckIfUserNameNotExist(users, userName))
                        {
                            PrintResult($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            PrintResult($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool CheckIfUserNameNotExist(Dictionary<string, string> users, string name) => !users.ContainsKey(name);

        static void PrintResult(string result) => Console.WriteLine(result);
    }
}