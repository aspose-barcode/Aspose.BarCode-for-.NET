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

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SetCodetextLocation 
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // ExStart:ControlAppearanceCodetext
            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the location of the code text to above the barcode
            barCodeBuilder.CodeLocation = CodeLocation.Above;

            // ExEnd:ControlAppearanceCodetext            
            // Save the image to your system in Jpeg format
            barCodeBuilder.Save(dataDir + "barcode-SetCodetextLocation_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
