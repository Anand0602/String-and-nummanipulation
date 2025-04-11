using System;
namespace Stringandnummanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you want to Manipulate?");
            Console.WriteLine("1. String Manipulation");
            Console.WriteLine("2. Number Manipulation");
            Console.WriteLine();

            int choice = Convert.ToInt32(Console.ReadLine());
            // String manipulation
            if (choice==1)
            {
                Console.WriteLine("Enter a string:");
                Console.WriteLine();
                string str = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("1. Reverse");
                Console.WriteLine("2. Uppercase");
                Console.WriteLine("3. Lowercase");
                Console.WriteLine("4. Count vowels");
                Console.WriteLine("5. Count consonants");
                Console.WriteLine();
                int strChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (strChoice == 1) {
                    //Reverse the string
                    char[] charArray = str.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine("Reversed string: " + new string(charArray));
                }
                else if (strChoice == 2)
                {
                    //Convert to uppercase

                    Console.WriteLine("Uppercase string: " + str.ToUpper());
                }
                else if (strChoice == 3)
                {
                    //Convert to lowercase
                    Console.WriteLine("Lowercase string: " + str.ToLower());
                }
                else if (strChoice == 4)
                {
                    //Count vowels
                    int count = 0;
                    foreach (char c in str)
                    {
                        if ("aeiouAEIOU".IndexOf(c) >= 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Number of vowels: " + count);
                }
                else if (strChoice == 5)
                {
                    //Count consonants
                    int count = 0;
                    foreach (char c in str)
                    {
                        if ("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".IndexOf(c) >= 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Number of consonants: " + count);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            }
            else if (choice == 2)
            {
                // Number manipulation
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Prime check");
                Console.WriteLine("3. Fibonacci");
                Console.WriteLine("4. Palindrome check");
                Console.WriteLine("5. Armstrong check");
                int numChoice = Convert.ToInt32(Console.ReadLine());
                if (numChoice == 1) {
                    //Factorial
                    int fact = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        fact *= i;
                    }
                    Console.WriteLine("Factorial of " + num + " is: " + fact);
                }
                else if (numChoice == 2)
                {
                    // Prime check
                    bool isPrime = true;
                    if (num < 2)
                        isPrime = false;
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    Console.WriteLine(num + " is " + (isPrime ? "a prime number" : "not a prime number"));
                }
                else if (numChoice == 3)
                {
                    // Fibonacci
                    int a = 0, b = 1, c;
                    Console.WriteLine("Fibonacci series up to " + num + ":");
                    Console.Write(a + " " + b + " ");
                    for (int i = 2; i < num; i++)
                    {
                        c = a + b;
                        Console.Write(c + " ");
                        a = b;
                        b = c;
                    }
                }
                else if (numChoice == 4)
                {
                    // Palindrome check
                    string strNum = num.ToString();
                    char[] charArray = strNum.ToCharArray();
                    Array.Reverse(charArray);
                    string reversedStrNum = new string(charArray);
                    Console.WriteLine(num + " is " + (strNum == reversedStrNum ? "a palindrome" : "not a palindrome"));
                }
                else if (numChoice == 5)
                {
                    // Armstrong check
                    int sum = 0, temp, digits = num.ToString().Length; 
                    temp = num;
                    while (temp != 0)
                    {
                        int digit = temp % 10;
                        sum += (int)Math.Pow(digit, digits);
                        temp /= 10;
                    }
                    Console.WriteLine(num + " is " + (sum == num ? "an Armstrong number" : "not an Armstrong number"));
                }
                else
                {
                    Console.WriteLine("Invalid choice");

                }
            }

            
        }
    }
}
