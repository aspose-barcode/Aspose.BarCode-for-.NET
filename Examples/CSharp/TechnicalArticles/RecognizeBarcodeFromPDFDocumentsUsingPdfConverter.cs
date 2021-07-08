using Aspose.BarCode.BarCodeRecognition;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class RecognizeBarcodeFromPDFDocumentsUsingPdfConverter
    {
        public static void Run()
        {
			// ExStart:RecognizeBarcodeFromPDFDocumentsUsingPdfConverter
			// For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
			try
			{
				// The path to the documents directory.
				string dataDir = RunExamples.GetDataDir_TechnicalArticles();

				// Bind the pdf document
				Aspose.Pdf.Facades.PdfConverter pdfConverter = new Aspose.Pdf.Facades.PdfConverter();
				pdfConverter.BindPdf(dataDir + @"document.pdf");

				// Set page range for image extraction
				pdfConverter.StartPage = 1;
				pdfConverter.EndPage = 1;
				
				// Set rendering optimization for barcodes
				pdfConverter.RenderingOptions.BarcodeOptimization = true;

				pdfConverter.DoConvert();

				// Save images to stream in a loop
				while (pdfConverter.HasNextImage())
				{
					// Save image to stream
					MemoryStream imageStream = new MemoryStream();
					pdfConverter.GetNextImage(imageStream);
					imageStream.Position = 0;

					// Recognize the barcode from the image stream above
					using (BarCodeReader reader = new BarCodeReader(imageStream, DecodeType.AllSupportedTypes))
					{
						var res = reader.ReadBarCodes();
						foreach (BarCodeResult result in res)
						{
							Console.WriteLine("Codetext found: " + result.CodeType + ", Symbology: " + result.CodeText);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			// ExEnd:RecognizeBarcodeFromPDFDocumentsUsingPdfConverter
			Console.WriteLine(Environment.NewLine + "Recognize BarCode From PDF Documents Finished.");
		}
	}
}
