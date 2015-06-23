using CSharp.BarCode_Image.Basic_Features;
using CSharp.BarCode_Image.Utility_Features;
using CSharp.BarCode_Recognition;
using CSharp.Programming_BarCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run");
            Console.WriteLine("=====================================================");
            // Un-comment the one you want to try out

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
