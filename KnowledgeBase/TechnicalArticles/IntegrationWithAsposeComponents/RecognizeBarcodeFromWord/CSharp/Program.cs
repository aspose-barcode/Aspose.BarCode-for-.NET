//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;
using Aspose.Words;
using Aspose.Words.Drawing;
using System.Drawing;
using System;
using Aspose.BarCodeRecognition;

namespace RecognizeBarcodeFromWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            
            // Load the word document
            Document wordDocument = new Document(dataDir + "input.doc");

            // get all the shapes
            NodeCollection shapes = wordDocument.GetChildNodes(NodeType.Shape, true, false);

            // loop through all the shapes
            foreach (Shape shape in shapes)
            {
                // check if it has an image
                if (shape.HasImage)
                {
                    // save the image in memory stream
                    MemoryStream imgStream = new MemoryStream();
                    shape.ImageData.Save(imgStream);

                    // recognize the barcode from the image stream above
                    BarCodeReader reader = new BarCodeReader(new Bitmap(imgStream), BarCodeReadType.Code39Standard);
                    while (reader.Read())
                    {
                        Console.WriteLine("Codetext found: " + reader.GetCodeText());
                    }

                    // close the reader
                    reader.Close();
                }
            }
        }
    }
}