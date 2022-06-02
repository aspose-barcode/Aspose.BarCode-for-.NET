//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class RecognizeBarcodesFromWordDocumentFromExtractedImages: WordIntegrationBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("RecognizeBarcodesFromWordDocumentFromExtractedImages:");

            //open Word document
            Aspose.Words.Document wordDoc = new Aspose.Words.Document($"{path}WordDocWithBarcodes.docx");

            foreach (Aspose.Words.Drawing.Shape wordShape in wordDoc.GetChildNodes(Aspose.Words.NodeType.Shape, true))
            {
                //we need only images
                if (!wordShape.HasImage) continue;

                //save the image data into memory stream
                MemoryStream ms = new MemoryStream(wordShape.ImageData.ImageBytes);

                //recognize Pdf417, QR, DataMatrix and Aztec barcode types from rendered image of the page
                BarCodeReader reader = new BarCodeReader(ms, DecodeType.Pdf417, DecodeType.QR, DecodeType.DataMatrix, DecodeType.Aztec);
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
            }
        }
	}
}