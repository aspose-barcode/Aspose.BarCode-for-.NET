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
    class SetQRErrorCorrection
    {
        public static void Run()
        {
            // ExStart:SetQRErrorCorrection   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Create instance of BarcodeGenerator, specify codetext and symbology in the constructor
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.QR, "1234567890");

            // Set QRErrorLevel and Save the file to disk.  
            generator.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelH;
            generator.Save(dataDir + "QR-error-correction_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:SetQRErrorCorrection   
        }
    }
}
