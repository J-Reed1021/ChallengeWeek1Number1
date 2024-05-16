namespace ChallengeLab1
{
    internal class TemperatureClassifications
    {

        static void Main()
        {
            string readResult;
            int temp;
            do
            {

                Console.Write("Enter the temperature or press 'X' to quit: ");
                temp = Convert.ToInt32(Console.ReadLine());
                readResult = Console.ReadLine();
            }
            while (temp <= 10 && temp >= 80);
                switch (readResult)
                {
                    case "X":
                    case "x":
                        break;
                }
            

                if (temp <= 10)
                {
                    Console.WriteLine("Freezing weather");
                }
                else if (temp > 10 && temp <= 20)
                {
                    Console.WriteLine("Very Cold weather");
                }
                else if (temp > 20 && temp <= 35)
                {
                    Console.WriteLine("Cold weather");
                }
                else if (temp > 35 && temp <= 50)
                {
                    Console.WriteLine("Normal in Weather");
                }
                else if (temp > 50 && temp <= 65)
                {
                    Console.WriteLine("It's Hot");
                }
                else if (temp > 65 && temp <= 80)
                {
                    Console.WriteLine("It's Very Hot");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }

