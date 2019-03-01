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
    class FNC1SecondPositionInExtendedMode
    {
        public static void Run()
        {
            //ExStart:FNC1SecondPositionInExtendedMode
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create codetext
            QrExtCodetextBuilder lTextBuilder = new QrExtCodetextBuilder();
            lTextBuilder.AddFNC1SecondPosition("12");
            lTextBuilder.AddPlainCodetext("TRUE3456");

            // Generate codetext
            string lCodetext = lTextBuilder.GetExtendedCodetext();

            // Instantiate barcode object and Set its CodeText, encoding mode, error correction level,  display text and Symbology
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR, lCodetext);
            generator.QR.EncodeMode = QREncodeMode.ExtendedCodetext;
            generator.QR.ErrorLevel = QRErrorLevel.LevelL;
            generator.D2.DisplayText = "My Text";

            // Get barcode image Bitmap and Save QR code
            Bitmap lBmp = generator.GenerateBarCodeImage();
            lBmp.Save(dataDir + "FNC1SecondPositionInExtendedMode_out.bmp", ImageFormat.Bmp);
            //ExEnd:FNC1SecondPositionInExtendedMode
        }
    }
}