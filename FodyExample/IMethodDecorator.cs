//  --------------------------------
//  <copyright file="IMethodDecorator.cs">
//      Copyright (c) 2015 All rights reserved.
//  </copyright>
//  <author>Alleshouse, Dale</author>
//  <date>03/08/2015</date>
//  ---------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

[SuppressMessage("Microsoft.Design", "CA1050:DeclareTypesInNamespaces")]
public interface IMethodDecorator
{
    void OnEntry(MethodBase method);
    void OnExit(MethodBase method);
    void OnException(MethodBase method, Exception exception);
}