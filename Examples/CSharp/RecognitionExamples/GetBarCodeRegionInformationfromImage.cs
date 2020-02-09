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

namespace Aspose.BarCode.Examples.CSharp.RecognitionExamples
{
    class GetBarCodeRegionInformationfromImage
    {
        public static void Run()
        {
            // ExStart:GetBarCodeRegionInformationfromImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Recognition();

            // Create an instance of BarCodeReader class and read barcode file
            BarCodeReader barCodeReader = new BarCodeReader(dataDir + "Region.png", DecodeType.Code39Standard);

            // Try to recognize all possible barcodes in the image
            while (barCodeReader.Read())
            {
                // Get the region information
                BarCodeRegion region = barCodeReader.GetRegion();
                if (region != null)
                {
                    // Display x and y coordinates of barcode detected
                    Point[] point = region.Points;
                    Console.WriteLine("Top left coordinates: X = " + point[0].X + ", Y = " + point[0].Y);
                    Console.WriteLine("Top right coordinates: X = " + point[1].X + ", Y = " + point[1].Y);
                    Console.WriteLine("Bottom right coordinates: X = " + point[2].X + ", Y = " + point[2].Y);
                    Console.WriteLine("Bottom left coordinates: X = " + point[3].X + ", Y = " + point[3].Y);
                }
                Console.WriteLine("Codetext: " + barCodeReader.GetCodeText());
            }
            // Close reader
            barCodeReader.Close();
            // ExEnd:GetBarCodeRegionInformationfromImage

        }
    }
}
