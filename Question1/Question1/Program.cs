﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_book;

namespace Question1
{
    class Program
    { //LIAM SULLIVAN STUDENT ID: 30022060
        static void Main(string[] args)
        {
            Console.WriteLine("\t***PLEASE ENTER BOOK DETAILS***\n");
            Book b1 = new Book();
            Console.Write("Enter Book Title Name: ");
            b1.tle = Console.ReadLine();
            Console.Write("Enter Book Author Name: ");
            b1.au = Console.ReadLine();
            Console.Write("Enter Book Publisher Name: ");
            b1.pub = Console.ReadLine();

            Console.WriteLine("\n***BOOK DETAILS***\n");
            Console.WriteLine(b1.Details());
            Console.ReadLine();
        }
    }

}
