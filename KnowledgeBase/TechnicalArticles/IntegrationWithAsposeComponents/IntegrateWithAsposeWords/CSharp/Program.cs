//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;
using System.Drawing;

using Aspose.BarCode;
using Aspose.Words;

namespace IntegrateWithAsposeWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code39Standard
            bb.SymbologyType = Symbology.Code39Standard;

            MemoryStream ms = new MemoryStream();

            bb.Save(ms, BarCodeImageFormat.Bmp);

            //Create doc with Aspose.Word.
            Document doc = new Document();

            //Create builder for doc.
            DocumentBuilder builder = new DocumentBuilder(doc);

            //Insert the BarCode image into doc
            builder.InsertImage(ms.GetBuffer());

            // Close memory stream.
            ms.Close();

            // Save the file
            doc.Save(dataDir + "Myfile.doc");

            System.Console.WriteLine("Myfile.doc file with embedded barcode image is created.\n");
        }
    }
}
