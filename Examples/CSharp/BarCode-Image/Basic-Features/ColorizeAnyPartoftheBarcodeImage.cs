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

namespace CSharp.BarCode_Image.Basic_Features
{
    class ColorizeAnyPartoftheBarcodeImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_BarCodeImage();
            string dst = dataDir + "colorize-barcode.jpg";

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128;

            //Set background color of the barcode
            bb.BackColor = System.Drawing.Color.Yellow;

            //Set color (fore color) of the barcode
            bb.ForeColor = System.Drawing.Color.Blue;

            //Set border color of the barcode
            bb.BorderColor = System.Drawing.Color.Red;

            //Set color of the code text of the barcode
            bb.CodeTextColor = System.Drawing.Color.Red;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
