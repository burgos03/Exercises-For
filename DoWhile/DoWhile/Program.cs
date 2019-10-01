using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWhileExercise();

        }

        //https://github.com/luis-fernando-camacho-dev-projects/CsharpCourse.git
        public static void DoWhileExercise()
        {
            int i = 65;
            do
            {
                Console.Write((char)i);
                i++;
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            while (i < 122);
        }
    }
}
