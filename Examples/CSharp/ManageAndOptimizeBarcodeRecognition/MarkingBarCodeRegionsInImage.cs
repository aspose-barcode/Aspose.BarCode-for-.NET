using System;
using System.Drawing;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class MarkingBarCodeRegionsInImage
    {
        public static void Run()
        {
            // ExStart:MarkingBarCodeRegionsInImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Create an instance of BarCodeReader and set image and symbology type to recognize
            using (BarCodeReader barCodeReader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code39Standard))
            {
                int counter = 0;

                // Read all the barcodes from the images
                foreach (BarCodeResult result in barCodeReader.ReadBarCodes())
                {
                    // Display the symbology type, codetext and Get the barcode region
                    Console.WriteLine("BarCode Type: " + result.CodeType);
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);

                    BarCodeRegionParameters region = result.Region;

                    if (region != null)
                    {
                        // Initialize an object of type Image to get the Graphics object
                        Image image = Image.FromFile(dataDir + "code39.png");

                        // Initialize graphics object from the image
                        Graphics graphics = Graphics.FromImage(image);

                        // Draw the barcode edges,  Save the image and Fill the barcode area with some color
                        //region.DrawBarCodeEdges(graphics, new Pen(Color.Red, 1f));
                        image.Save(dataDir + string.Format(@"edge_{0}.png", counter++));
                        //region.FillBarCodeRegion(graphics, Brushes.Green);
                        //image.Save(dataDir + string.Format(@"fill_{0}.png", counter++));
                    }
                }
            }
            // ExEnd:MarkingBarCodeRegionsInImage
        }
    }
}
