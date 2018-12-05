using System;

namespace Exercises.IterationStatements
{
    class ForEachLoops
    {
        public void SpellName()
        {
            var name = "John Smith";
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
        }

        public void IterateNumbers()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
