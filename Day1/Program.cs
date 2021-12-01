using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent
{
    class Program
    {
        static void Main(string[] args)
        {
             var input =File.ReadAllText("input.txt").Split("\n").Select( x=> int.Parse(x)).ToList();
                     
             var total  = 0;

             for(int i = 0; i < input.Count() ; i++)
             {
                 if (i == 0)
                    continue;
                
                if(input[i] > input[i-1])
                    total+=1;
                    
             }

             Console.WriteLine(total);
             
             total = 0;

              for(int i = 0; i < input.Count() ; i++)
             {
                  if (i == 0)
                    continue;
                  if (i == input.Count() - 2)
                    break;
                if(input[i]+input[i+1]+input[i+2] > input[i-1]+input[i]+input[i+1])
                    total+=1;

             }

             Console.WriteLine(total);

        }
    }
}
