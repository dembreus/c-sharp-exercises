using System;

namespace Exercises.IterationStatements
{

        class DoWhile
        {
            public void GeneratePassword()
            {
                var random = new Random();
                const int passwordLength = 10;

                var buffer = new char[passwordLength];
                int i = 0;
                do
                {
                    buffer[i] = (char)('a' + random.Next(0, 26));
                    i++;
                }
                while (i < 10);

                var password = new string(buffer);

                Console.WriteLine(password);
            }
        }
    
}

