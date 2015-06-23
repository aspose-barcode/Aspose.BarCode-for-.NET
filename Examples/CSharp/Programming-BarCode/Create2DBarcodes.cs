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
    class Create2DBarcodes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "2d-barcode.jpg";

            Aspose.BarCode.BarCodeBuilder b;
            b = new Aspose.BarCode.BarCodeBuilder();
            b.SymbologyType = Aspose.BarCode.Symbology.Pdf417;
            // width of each module
            b.xDimension = 0.6f;
            // height of each module
            b.yDimension = 1.2f;
            b.CodeText = "this is some test code text. \n Second line \n third line.";
            b.Save(dst, BarCodeImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
