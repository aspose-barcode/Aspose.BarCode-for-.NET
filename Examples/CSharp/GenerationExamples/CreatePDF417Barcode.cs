using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.GenerationExamples
{
    class CreatePDF417Barcode
    {
        public static void Run()
        {
            // ExStart:CreatePDF417Barcode    
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate BarcodeGenerator object Set the Code text & SymbologyType for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "1234567890");
            generator.Save(dataDir + "pdf417-barcode_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:CreatePDF417Barcode    
        }
    }
}
