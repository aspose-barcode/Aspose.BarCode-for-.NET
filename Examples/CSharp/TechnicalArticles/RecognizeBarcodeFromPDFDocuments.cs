using Aspose.BarCode.BarCodeRecognition;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class RecognizeBarcodeFromPDFDocuments
    {
        public static void Run()
        {
			// ExStart:RecognizeBarcodeFromPDFDocuments
			// For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
			try
			{
				// The path to the documents directory.
				string dataDir = RunExamples.GetDataDir_TechnicalArticles();

				// Bind the pdf document
				Pdf.Facades.PdfExtractor pdfExtractor = new Pdf.Facades.PdfExtractor();
				pdfExtractor.BindPdf(dataDir + @"document.pdf");

				// Set page range for image extraction
				pdfExtractor.StartPage = 1;
				pdfExtractor.EndPage = 1;

				// Extract the images
				Console.WriteLine("Extracting images....");
				pdfExtractor.ExtractImage();

				// Save images to stream in a loop
				while (pdfExtractor.HasNextImage())
				{
					Console.WriteLine("Getting next image....");

					// Save image to stream
					MemoryStream imageStream = new MemoryStream();
					pdfExtractor.GetNextImage(imageStream);
					imageStream.Position = 0;
					Console.WriteLine("Recognizing barcode....");

					// Recognize the barcode from the image stream above
					using (BarCodeReader reader = new BarCodeReader(imageStream, DecodeType.Code39Standard))
					{
						foreach (BarCodeResult result in reader.ReadBarCodes())
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
			// ExEnd:RecognizeBarcodeFromPDFDocuments
			Console.WriteLine(Environment.NewLine + "Recognize BarCode From PDF Documents Finished.");
		}
	}
}
