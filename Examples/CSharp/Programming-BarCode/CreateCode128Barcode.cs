//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;
using System;

namespace CSharp.Programming_BarCode
{
    class CreateCode128Barcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "Code128-customized.png";

            // Set codetext
            string codeText = "1234";

            // Initialize BarCodeBuilder
            BarCodeBuilder builder = new BarCodeBuilder(codeText, Symbology.Code128);
            // Code128 type handles Code A, B and C character sets automatically
            
            // Save the image to disk in PNG format
            builder.Save(dst);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
