using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exeption
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter number");
            try {
                x = Convert.ToInt32(Console.ReadLine());
                //throw new Exception("bhen k loray");
                
                
            }catch(Exception a){
                Console.WriteLine(" enter only number " + a);
            
            }
            finally
            {
                Console.WriteLine("asdasda");
            }
            Console.ReadKey();
        }
    }
}
