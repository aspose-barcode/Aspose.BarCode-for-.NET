using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/


namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GeneratingGS1ForCodablock
    {
        public static void Run()
        {
            // ExStart:GeneratingGS1ForCodablock
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarcodeGenerator  class.
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.GS1CodablockF, "(01)03412345678900(17)010200");

            // Save the image to disk in PNG format
            generator.Save("GS1CodablockF_out.png", BarCodeImageFormat.Png);
            // ExEnd:GeneratingGS1ForCodablock
        }
    }
}
