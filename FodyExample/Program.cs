//  --------------------------------
//  <copyright file="Program.cs">
//      Copyright (c) 2015 All rights reserved.
//  </copyright>
//  <author>Alleshouse, Dale</author>
//  <date>03/08/2015</date>
//  ---------------------------------

namespace FodyExample
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    internal class Program
    {
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args")]
        private static void Main(string[] args)
        {
            var service = new SomeService();
            Console.WriteLine(service.GetNameLength(new SomeObject() { Name = "Something" }));
        }
    }
}