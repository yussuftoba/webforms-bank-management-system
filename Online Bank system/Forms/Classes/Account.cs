using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user;

namespace Online_Bank_system.Forms.Classes
{
    internal class Account
    {
        public double balance;
        public string creditCardNumber;

        public bool isValid()
        {
            return false;
        }

        public int Digit(int number)
        {
            int sumOfDigit = 0;
            while (number > 0)
            {
                sumOfDigit += number % 10;
                number /= 10;
            }
            return sumOfDigit;
        }

        public int sumEvenDigit(string Account_Number)
        {
            int sum = 0;
            for (int i = Account_Number.Length - 2; i >= 0; i -= 2)
            {
                sum += Digit((Account_Number[i] - '0') * 2);
            }
            return sum;
        }

        public int sumOddDigit(string Account_Number)
        {
            int sum = 0;
            for (int i = Account_Number.Length - 1; i >= 0; i -= 2)
            {
                sum += Account_Number[i] - '0';
            }
            return sum;
        }
    }
}
