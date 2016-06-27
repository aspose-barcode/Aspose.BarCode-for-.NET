using System.IO;
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class HideBarcodeCodeText
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set CodeText 
            barCodeBuilder.CodeText = "The quick brown fox jumps over the lazy dog\n" + "The quick brown fox jumps over the lazy dog\n"; ;

            // Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.DataMatrix;

            // Set Barcode CodeLocation
            barCodeBuilder.CodeLocation = CodeLocation.None;

            // Save the Barcode image
            barCodeBuilder.Save(dataDir + "HideBarcodeCodeText_out.png", BarCodeImageFormat.Png);
        }
    }
}
