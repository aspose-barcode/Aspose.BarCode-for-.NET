//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;

using Aspose.BarCode;
using Aspose.BarCodeRecognition;

namespace RecognizeBarcodeFromPdf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            try
            {
                // bind the pdf document
                Aspose.Pdf.Facades.PdfExtractor pdfExtractor = new Aspose.Pdf.Facades.PdfExtractor();
                pdfExtractor.BindPdf(dataDir + "document.pdf");
                
                // set page range for image extraction
                pdfExtractor.StartPage = 1;
                pdfExtractor.EndPage = 1;
                
                // extract the images
                System.Console.WriteLine("Extracting images.....");
                pdfExtractor.ExtractImage();
                
                // save images to stream in a loop
                while (pdfExtractor.HasNextImage())
                {
                    System.Console.WriteLine("Getting next image....");
                    
                    // save image to stream
                    MemoryStream imageStream = new MemoryStream();
                    pdfExtractor.GetNextImage(imageStream);
                    imageStream.Position = 0;

                    System.Console.WriteLine("Recognizing barcode....");
                    
                    // recognize the barcode from the image stream above
                    Aspose.BarCodeRecognition.BarCodeReader barcodeReader = new Aspose.BarCodeRecognition.BarCodeReader(imageStream, BarCodeReadType.Code39Standard);
                    while (barcodeReader.Read())
                    {
                        System.Console.WriteLine("Codetext found: " + barcodeReader.GetCodeText() + ", Symbology: " + barcodeReader.GetReadType().ToString());
                    }
                    // close the reader
                    barcodeReader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}