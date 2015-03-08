//  --------------------------------
//  <copyright file="SomeService.cs">
//      Copyright (c) 2015 All rights reserved.
//  </copyright>
//  <author>Alleshouse, Dale</author>
//  <date>03/08/2015</date>
//  ---------------------------------
namespace FodyExample
{
    using System;

    public class SomeService
    {
        public int GetNameLength(SomeObject o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            return o.Name.Length;
        }
    }
}