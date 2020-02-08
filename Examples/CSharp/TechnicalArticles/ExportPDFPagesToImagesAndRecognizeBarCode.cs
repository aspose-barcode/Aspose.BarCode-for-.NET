using Aspose.BarCode.BarCodeRecognition;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class ExportPDFPagesToImagesAndRecognizeBarCode
    {
        public static void Run()
        {
			//ExStart:ExportPDFPagesToImagesAndRecognizeBarCode
			// For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

			// The path to the documents directory.
			string dataDir = RunExamples.GetDataDir_TechnicalArticles();
			try
			{
				Document pdfDocument = new Document(dataDir + "document.pdf");
				int pageCount = pdfDocument.Pages.Count;
				for (var i = 1; i <= pageCount; i++)
				{
					var converter = new PdfConverter();
					converter.BindPdf(dataDir + @"document.pdf");
					converter.StartPage = i;
					converter.EndPage = i;
					converter.DoConvert();
					MemoryStream stream = new MemoryStream();
					converter.GetNextImage(stream, ImageFormat.Png);

					using (BarCodeReader reader = new BarCodeReader(stream, DecodeType.Code93Standard))
					{
						foreach (BarCodeResult result in reader.ReadBarCodes())
						{
							Console.WriteLine("Codetext found: " + result.CodeType + ", Symbology: " + result.CodeText);
						}
					}
					converter.Close();
					converter.Dispose();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			//ExEnd:ExportPDFPagesToImagesAndRecognizeBarCode
			Console.WriteLine(Environment.NewLine + "Export PDF Pages To Images And Recognize BarCode Finished.");
		}
	}
}
