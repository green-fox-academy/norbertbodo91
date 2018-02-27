using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoo
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideTen(0);

        }
        static void DivideTen(int num)
        {
            try  
            {            
                int divisor = 10;
                
                int result = num / divisor;

                if(num == 0)
                {
                    Console.WriteLine("Fail!");
                }
                else
                {

                    Console.WriteLine(result);
                        
                }
                
            }
            catch (DivideByZeroException e)
            {
                
                Console.WriteLine("Fail!");

            }
            catch (Exception e)
            {
                
                Console.WriteLine("uuups");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
