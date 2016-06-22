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
    class ControlBarsFillingofOneDBarcodes
    {
        public static void Run()
        {
            //ExStart:ControlBarsFillingofOneDBarcodes
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            using (BarCodeBuilder builder = new BarCodeBuilder("TEXT", Symbology.Code128))
            {
                builder.FilledBars = false;
                builder.Save(dataDir + "ControlBarsFillingofOneDBarcodes_out.png");
            }
            //ExEnd:ControlBarsFillingofOneDBarcodes
        }
    }
}
