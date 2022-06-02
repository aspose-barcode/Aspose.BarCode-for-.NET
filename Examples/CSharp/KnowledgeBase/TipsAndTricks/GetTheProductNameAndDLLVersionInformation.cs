//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;

namespace Aspose.BarCode.Examples.CSharp.KnowledgeBase
{
    internal class GetTheProductNameAndDLLVersionInformation
    {
		public static void Run()
        {
            Console.WriteLine("GetTheProductNameAndDLLVersionInformation:");

            //the code shows system information about Aspose.BarCode dll
            Console.WriteLine("Assembly version: " + BuildVersionInfo.AssemblyVersion);
            Console.WriteLine("File Version: " + BuildVersionInfo.FileVersion);
            Console.WriteLine("Product: " + BuildVersionInfo.Product);
            Console.WriteLine("Product Major: " + BuildVersionInfo.ProductMajor);
            Console.WriteLine("Product Minor: " + BuildVersionInfo.ProductMinor);
            Console.WriteLine("Release Date: " + BuildVersionInfo.ReleaseDate);
        }
	}
}