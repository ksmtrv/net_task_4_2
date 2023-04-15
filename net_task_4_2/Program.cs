using System;

namespace net_task_4_2
{
 class Program
    {
        static void Exit()
        {
            System.Environment.Exit(1);
        }

        static void Main(string[] args) {

            MobileOperator mobileOperator = new MobileOperator("Beeline", 10, 100);
            Console.WriteLine(mobileOperator.GetInfoStr());

            MobileOperator mobileOperator2 = new MobileOperator("Tele2", 50, 100);
            Console.WriteLine(mobileOperator2.GetInfoStr());

            MobileOperatorDerived mobileOperatorDerived = new MobileOperatorDerived("MTS", 10, 15, true);
            Console.WriteLine(mobileOperatorDerived.GetInfoStr());

            string input = "";
            while (true) {
                Console.WriteLine("Enter type of obj to create: 1 - Base Mobile op, 2 - Derived Mobile op");
                input = Console.ReadLine();
                if (int.TryParse(input, out int i))
                {
                    switch (int.Parse(input)) {
                        case 1:
                            CreateMobileOp();
                            break;
                        case 2:
                            CreateMobileOp(true);
                            break;
                        default:
                            Exit();
                            break;
                    }
                }
            }
        }

        private static void CreateMobileOp(bool derived = false)
        {
            Console.WriteLine($"Enter name, call cost, coverage area {(derived ? ", connection fee" : "")}");
            string input = Console.ReadLine();
            if (input != null)
            {
                string[] splitted = input.Split(' ');
                if (
                    splitted.Length == 3 &&
                    double.TryParse(splitted[1], out double d1) &&
                    int.TryParse(splitted[2], out int i1)
                    ) 
                {
                    Console.WriteLine(new MobileOperator(splitted[0], d1, i1).GetInfoStr());
                }
                else if (
                    splitted.Length == 4 &&
                    double.TryParse(splitted[1], out double d2) &&
                    int.TryParse(splitted[2], out int i2) &&
                    bool.TryParse(splitted[3], out bool b)
                    )
                {
                    Console.WriteLine(new MobileOperatorDerived(splitted[0], d2, i2, b).GetInfoStr());
                }
            }

        }
    }
}