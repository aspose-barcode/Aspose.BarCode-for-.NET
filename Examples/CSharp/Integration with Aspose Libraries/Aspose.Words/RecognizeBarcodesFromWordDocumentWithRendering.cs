//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class RecognizeBarcodesFromWordDocumentWithRendering: WordIntegrationBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("RecognizeBarcodesFromWordDocumentWithRendering:");
            
            //open Word document
            Aspose.Words.Document wordDoc = new Aspose.Words.Document($"{path}WordDocWithBarcodes.docx");

            //proceed all word pages
            for (int i = 0; i < wordDoc.PageCount; ++i)
            {
                //create options to save
                Aspose.Words.Saving.ImageSaveOptions wordSaveOptions = new Aspose.Words.Saving.ImageSaveOptions(Aspose.Words.SaveFormat.Png);
                //set required page
                wordSaveOptions.PageSet = new Aspose.Words.Saving.PageSet(i);
                //set rendering resolution to 300 dpi
                wordSaveOptions.Resolution = 300;//300 dpi

                //render to memory stream
                MemoryStream ms = new MemoryStream();
                wordDoc.Save(ms, wordSaveOptions);
                ms.Position = 0;

                //recognize Pdf417, QR, DataMatrix and Aztec barcode types from rendered image of the page
                BarCodeReader reader = new BarCodeReader(ms, DecodeType.Pdf417, DecodeType.QR, DecodeType.DataMatrix, DecodeType.Aztec);
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
            }
        }
    }
}