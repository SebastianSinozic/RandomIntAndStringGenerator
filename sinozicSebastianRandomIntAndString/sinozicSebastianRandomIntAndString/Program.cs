using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianRandomIntAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator rand = new Generator();
            int i = rand.RandomNumber(1, 1000);
            Console.WriteLine(i);
            string password = rand.RandomPassword();
            Console.WriteLine(password);

            string str = rand.RandomString(15, false);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
    class Generator
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size    
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password    
       
        public string RandomPassword()
        {
            
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        
        }
    
    }
}