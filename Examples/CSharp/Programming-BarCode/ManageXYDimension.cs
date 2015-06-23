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
    class ManageXYDimension
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dstCode128 = dataDir + "code128-YDimensionChanged.jpg";
            string dstPdf417 = dataDir + "pdf417-YDimensionChanged.jpg";

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Set the X-Dimension for the bars of the barcode
            bb.xDimension = 0.5f;

            //Set the measuring unit of barcode to millimeter
            bb.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg);


            //Instantiate barcode object
            BarCodeBuilder bb1 = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb1.CodeText = "1234567";

            //Set the symbology type to Pdf417
            bb1.SymbologyType = Symbology.Pdf417;

            //Set the Y-Dimension for the bars of the barcode
            bb1.yDimension = 4;

            //Save the image to your system
            //and set its image format to Jpeg
            bb1.Save(dstPdf417, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dstCode128);
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dstPdf417);
        }
    }
}
