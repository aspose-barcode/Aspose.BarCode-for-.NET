using Aspose.BarCode.BarCodeRecognition;
using Aspose.Words;
using Aspose.Words.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class RecognizeBarcodeFromWordDocument
    {
		public static void Run()
		{
			// ExStart:RecognizeBarcodeFromWordDocument
			// For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

			// The path to the documents directory.
			string dataDir = RunExamples.GetDataDir_TechnicalArticles();

			// Load the word document, get all the shapes
			Document wordDocument = new Document(dataDir + "Document.doc");
			NodeCollection shapes = wordDocument.GetChildNodes(NodeType.Shape, true);

			// Loop through all the shapes
			foreach (Shape shape in shapes)
			{
				// Check if it has an image
				if (shape.HasImage)
				{
					// Save the image in memory stream
					MemoryStream imgStream = new MemoryStream();
					shape.ImageData.Save(imgStream);

					// Recognize the barcode from the image stream above
					using (BarCodeReader reader = new BarCodeReader(new Bitmap(imgStream), DecodeType.Code39Standard))
					{
						foreach (BarCodeResult result in reader.ReadBarCodes())
						{
							Console.WriteLine("Codetext found: " + result.CodeType + ", Symbology: " + result.CodeText);
						}
					}
				}
				// ExEnd:RecognizeBarcodeFromWordDocument
				Console.WriteLine(Environment.NewLine + "Recognize Barcode From Word Document Finished.");
			}
		}
    }
}