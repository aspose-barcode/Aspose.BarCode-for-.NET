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
    class SetAspectRatio
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            //ExStart:SetAspectRatio
            // Create instance of BarCodeBuilder class

            BarCodeBuilder builder = new BarCodeBuilder("1234567890", Symbology.Pdf417);
            // Set Aspect Ratio to 3:2 or 1.5
            
            builder.AspectRatio = 1.5f;
            // Save the barcode image to disk in PNG format
            
            builder.Save(dataDir + "SetAspectRatio_out.png", BarCodeImageFormat.Png);
            //ExEnd:SetAspectRatio
        }
    }
}
