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
    class GetBarCodeRegionInformationfromImage
    {
        public static void Run()
        {
            // ExStart:GetBarCodeRegionInformationfromImage
            
            ReadBarcodeRegionPoints();
            ReadBarcodeRegionQuadrangle();
            ReadBarcodeRegionRectangle();

            // ExEnd:GetBarCodeRegionInformationfromImage

        }

        public static void ReadBarcodeRegionPoints()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Create an instance of BarCodeReader class and read barcode file
            using (BarCodeReader barCodeReader = new BarCodeReader(dataDir + "Region.png", DecodeType.Code39Standard))
                foreach (BarCodeResult result in barCodeReader.ReadBarCodes())
                {
                    // Display x and y coordinates of barcode detected
                    Console.WriteLine("Top left coordinates: X = " + result.Region.Points[0].X + ", Y = " + result.Region.Points[0].Y);
                    Console.WriteLine("Top right coordinates: X = " + result.Region.Points[1].X + ", Y = " + result.Region.Points[1].Y);
                    Console.WriteLine("Bottom right coordinates: X = " + result.Region.Points[2].X + ", Y = " + result.Region.Points[2].Y);
                    Console.WriteLine("Bottom left coordinates: X = " + result.Region.Points[3].X + ", Y = " + result.Region.Points[3].Y);
                    //codetext
                    Console.WriteLine("Codetext: " + result.CodeText);
                }
        }
        
        public static void ReadBarcodeRegionQuadrangle()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Create an instance of BarCodeReader class and read barcode file
            using (BarCodeReader barCodeReader = new BarCodeReader(dataDir + "Region.png", DecodeType.Code39Standard))
                foreach (BarCodeResult result in barCodeReader.ReadBarCodes())
                {
                    // Display x and y coordinates of barcode detected
                    Console.WriteLine("Top left coordinates: X = " + result.Region.Quadrangle.LeftTop.X + ", Y = " + result.Region.Quadrangle.LeftTop.Y);
                    Console.WriteLine("Top right coordinates: X = " + result.Region.Quadrangle.RightTop.X + ", Y = " + result.Region.Quadrangle.RightTop.Y);
                    Console.WriteLine("Bottom right coordinates: X = " + result.Region.Quadrangle.RightBottom.X + ", Y = " + result.Region.Quadrangle.RightBottom.Y);
                    Console.WriteLine("Bottom left coordinates: X = " + result.Region.Quadrangle.LeftBottom.X + ", Y = " + result.Region.Quadrangle.LeftBottom.Y);
                    //codetext
                    Console.WriteLine("Codetext: " + result.CodeText);
                }
        }

        public static void ReadBarcodeRegionRectangle()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Create an instance of BarCodeReader class and read barcode file
            using (BarCodeReader barCodeReader = new BarCodeReader(dataDir + "Region.png", DecodeType.Code39Standard))
                foreach (BarCodeResult result in barCodeReader.ReadBarCodes())
                {
                    // Display region rectangle
                    Console.WriteLine("Barcode Rectangle: " + result.Region.Rectangle.ToString());
                    //codetext
                    Console.WriteLine("Codetext: " + result.CodeText);
                }
        }

    }
}
