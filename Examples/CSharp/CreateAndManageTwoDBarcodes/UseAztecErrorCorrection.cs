using System.IO;
using System;
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
    class UseAztecErrorCorrection
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();
            
            // Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.Aztec;

            // Set Error Error Correction level
            barCodeBuilder.AztectErrorLevel = 10;

            // Set CodeText 
            barCodeBuilder.CodeText = "123456789";

            // Save the Barcode image
            barCodeBuilder.Save(dataDir + "UseAztecErrorCorrection_out.bmp", BarCodeImageFormat.Bmp);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "UseAztecErrorCorrection_out.bmp");
        }
    }
}
