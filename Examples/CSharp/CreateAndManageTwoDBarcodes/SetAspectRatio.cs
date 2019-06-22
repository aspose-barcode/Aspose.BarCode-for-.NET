using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class SetAspectRatio
    {
        public static void Run()
        {
            //ExStart:SetAspectRatio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create instance of BarcodeGenerator  class, Set Aspect Ratio to 3:2 or 1.5 and Save the barcode image to disk in PNG format  
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Pdf417, "1234567890");
            generator.Parameters.Barcode.Pdf417.AspectRatio = 1.5f;
            
            generator.Save(dataDir + "SetAspectRatio_out.png", BarCodeImageFormat.Png);
            //ExEnd:SetAspectRatio
        }
    }
}
