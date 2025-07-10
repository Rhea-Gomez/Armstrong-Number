namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, remainder, sum = 0, temp;
            Console.Write("Enter a number to check whether it is Armstrong number or not: ");
            num = int.Parse(Console.ReadLine());

            temp = num;
            while (temp > 0)
            {
                remainder = temp % 10;
                sum = sum + (remainder * remainder * remainder);
                temp = temp / 10;
            }
            if (sum == num)
                Console.Write(num + " is an Armstrong Number.");
            else
                Console.Write(num + " is not an Armstrong Number.");
        }
    }
    }

