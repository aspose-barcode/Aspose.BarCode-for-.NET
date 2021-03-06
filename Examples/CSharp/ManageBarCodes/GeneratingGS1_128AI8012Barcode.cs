﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GeneratingGS1_128AI8012Barcode
    {
        public static void Run()
        {
            // ExStart:GeneratingGS1_128AI8012Barcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarcodeGenerator  class.
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.GS1Code128, "(8012)ABC123");

            // Save the image to disk in PNG format
            generator.Save("AI8012_out.png", BarCodeImageFormat.Png);
            // ExEnd:GeneratingGS1_128AI8012Barcode
        }
    }
}
