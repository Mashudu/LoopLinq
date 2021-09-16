using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var ctx = new OCREntities();
            var sorteds = ctx.Sorteds.Where(x=>x.Class.Equals("Vodacom Quotation"));
           string rootFolderPath = @"C:\Users\mulem001\Downloads\Dump File need sorting\Dump File need sorting\";
            string destinationPath = @"C:\Users\mulem001\Downloads\Dump File need sorting\Dump File need sorting\VQ\";
            int i = 0;
           
            foreach (Sorted s in sorteds)
            {
                i++;
                string fileToMove = rootFolderPath + s.FileName;
                string moveTo = destinationPath + s.FileName;
                //moving file
                File.Move(fileToMove, moveTo);
                Console.WriteLine("Moved <----->"+s.FileName);

            }
          
            Console.ReadKey();

        }
    }
}
