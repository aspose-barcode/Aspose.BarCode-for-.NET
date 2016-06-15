using Aspose.BarCode.Examples.CSharp.BarCode.Recognition;
using Aspose.BarCode.Examples.CSharp.Programming.BarCode;
using Aspose.BarCode.Examples.CSharp.BarCode.Image.Basic.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the example that you want to run.

            //// =====================================================
            //// =====================================================
            //// Programming BarCode
            //// =====================================================
            //// =====================================================

            CreateCode128Barcode.Run();
            //GenerateAustraliaPostBarcode.Run();
            //ManageXYDimension.Run();
            //SetHeightBarcodeBars.Run();
            //CodabarStartStopSymbols.Run();
            //ChecksumSupplementData.Run();
            //WideNarrowRatio.Run();
            //CodetextAppearance.Run();
            //BarcodeCaption.Run();
            //SetCodeText.Run();
            //SpecifySymbology.Run();
            //SetQREncodeMode.Run();
            //SetQRErrorCorrection.Run();
            //CreateQRbarcode.Run();
            //RotateBarcode.Run();
            //CreateDatamatrixBarcode.Run();
            //CreatePDF417Barcode.Run();
            //Create2DBarcodes.Run();

            //// =====================================================
            //// =====================================================
            //// BarCode Image
            //// =====================================================
            //// =====================================================

            //// Basic Features
            //// =====================================================

            //ColorizeAnyPartoftheBarcodeImage.Run();
            //BarcodeImageQuality.Run();
            //RotateBarcodeImage.Run();
            //BarcodeImageMargins.Run();
            //BarcodeImageBorders.Run();

            //// Utility Features
            //// =====================================================

            //BarcodeImageResolution.Run();
            //BarcodeCustomSize.Run();
            //PrintBarcodeImage.Run();
            //SaveBarcodeImagesToDifferentFormats.Run();
            //SetSizeUnitForBarcodeImage.Run();

            //// =====================================================
            //// =====================================================
            //// BarCode Recognition
            //// =====================================================
            //// =====================================================

            //DetectOrientationOfBarCode.Run();

            // Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....");
            Console.ReadKey();
        }

        internal static string GetDataDir_ProgrammingBarCode()
        {
            return Path.GetFullPath("../../Programming-BarCode/Data/");
        }

        internal static string GetDataDir_BarCodeImage()
        {
            return Path.GetFullPath("../../BarCode-Image/Data/");
        }

        internal static string GetDataDir_BarCodeRecognition()
        {
            return Path.GetFullPath("../../BarCode-Recognition/Data/");
        }
    }
}
