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

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SpecifySymbologies
    {
        public static void Run()
        {
            //ExStart:SpecifySymbologies
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            // Set the Code text for the barcode
            bb.CodeText = "1234567";

            // Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128;

            //ExEnd:SpecifySymbologies
            // Save the image to your system and set its image format to Jpeg
            bb.Save(dataDir + "barcode-SpecifySymbologies_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
