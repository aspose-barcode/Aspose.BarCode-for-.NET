//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.BarCodeRecognition;
using System.Drawing.Imaging;

namespace PdfToImagesToBarCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Document pdfDocument = new Document(dataDir + "document.pdf");
            int pageCount = pdfDocument.Pages.Count;

            for (var i = 1; i <= pageCount; i++)
            {
                var converter = new PdfConverter();
                converter.BindPdf(dataDir + "document.pdf");
                converter.StartPage = i;
                converter.EndPage = i;
                converter.DoConvert();

                MemoryStream stream = new MemoryStream();
                converter.GetNextImage(stream, ImageFormat.Png);
                using (BarCodeReader reader = new BarCodeReader(stream, BarCodeReadType.Code39Standard))
                {
                    while (reader.Read())
                    {
                        System.Console.WriteLine("Page#" + i + " -- Symbol:" + reader.GetReadType() + " Code :" + reader.GetCodeText());
                    }
                }
                converter.Close();
                converter.Dispose();
            }
 
        }
    }
}