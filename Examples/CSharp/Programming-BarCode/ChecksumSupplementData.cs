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
    class ChecksumSupplementData
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "code39-checeksum.png";

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code39
            bb.SymbologyType = Symbology.Code39Standard;

            //Make the checksum to be visible on the barcode
            bb.EnableChecksum = EnableChecksum.Yes;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dst);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
