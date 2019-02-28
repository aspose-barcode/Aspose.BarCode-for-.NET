using System.Drawing;
using System.Drawing.Imaging;
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
    class FNC1FirstPositionInExtendedMode
    {
        public static void Run()
        {
            //ExStart:FNC1FirstPositionInExtendedMode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create codetext
            QrExtCodetextBuilder lTextBuilder = new QrExtCodetextBuilder();
            lTextBuilder.AddFNC1FirstPosition();
            lTextBuilder.AddPlainCodetext("000%89%%0");
            lTextBuilder.AddFNC1GroupSeparator();
            lTextBuilder.AddPlainCodetext("12345<FNC1>");

            // Generate codetext
            string lCodetext = lTextBuilder.GetExtendedCodetext();

            // Instantiate barcode object and Set Codetext & SymbologyType
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR, "1234567890");

            // Set encoding mode, error correction level and display text
            generator.QR.EncodeMode = QREncodeMode.ExtendedCodetext;
            generator.QR.ErrorLevel = QRErrorLevel.LevelL;
            generator.D2.DisplayText = "My Text";

            // Get barcode image Bitmap and Save QR code
            Bitmap lBmp = generator.GenerateBarCodeImage();
            lBmp.Save(dataDir + "FNC1FirstPositionInExtendedMode_out.bmp", ImageFormat.Bmp);
            //ExEnd:FNC1FirstPositionInExtendedMode
        }
    }
}
