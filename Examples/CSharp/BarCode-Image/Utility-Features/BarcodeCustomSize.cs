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

namespace CSharp.BarCode_Image.Utility_Features
{
    class BarcodeCustomSize
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_BarCodeImage();
            string dst = dataDir + "barcode-custom-size.jpg";

            //Instantiate barcode object
            BarCodeBuilder builder = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

            // Set auto size false
            builder.AutoSize = false;

            // Set height
            builder.ImageHeight = 50;

            // Set width
            builder.ImageWidth = 120;

            // Save image to disk
            builder.Save(dst);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
