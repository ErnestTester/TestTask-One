using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;

namespace Project
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stat!");
            MyLog logger = new MyLog("LogProject.txt");

         
      
            logger.Info("User logged in.");
            logger.Warning("Failed login attempt.");
            Console.WriteLine("End to capture the logs");
        }
            
           
    }
}
