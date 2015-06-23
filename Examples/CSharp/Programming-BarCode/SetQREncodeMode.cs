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
    class SetQREncodeMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "QR-Encode-mode.jpg";

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("test123", Symbology.QR);

            // Set QR encode mode
            builder.QREncodeMode = Aspose.BarCode.QREncodeMode.Auto;

            // Save the image to disk in PNG format
            builder.Save(dst);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
