using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGitApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my git practice work");
            count();
            Console.WriteLine("ready to commit");
        }
        static void count()
        {
            foreach(int i in Enumerable.Range(0, 10)){
                Console.WriteLine(i);
            }
        }
    }
}
