using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CountCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input some string and press Enter");
            string userStringInput= Console.ReadLine();
            
            Algorithms groupingAlgorithm = new Algorithms(userStringInput);

            groupingAlgorithm.ListAlgorithm();
            groupingAlgorithm.ArrayAlgorithm();

        }
    }
}
