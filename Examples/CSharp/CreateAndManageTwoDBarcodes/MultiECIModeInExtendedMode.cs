using System.IO;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class MultiECIModeInExtendedMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create codetext
            QrExtCodetextBuilder lTextBuilder = new QrExtCodetextBuilder();
            lTextBuilder.AddECICodetext(ECIEncodings.Win1251, "Will");
            lTextBuilder.AddECICodetext(ECIEncodings.UTF8, "Right");
            lTextBuilder.AddECICodetext(ECIEncodings.UTF16BE, "Power");
            lTextBuilder.AddPlainCodetext(@"t\e\\st");

            // Generate codetext
            string lCodetext = lTextBuilder.GetExtendedCodetext();

            // Initialize a BarCodeBuilder class object, Set CodeText, Symbology, Encoding mode, correction level and display text
            BarCodeBuilder builder = new BarCodeBuilder(lCodetext, EncodeTypes.QR);
            builder.QREncodeMode = QREncodeMode.ExtendedCodetext;
            builder.QRErrorLevel = QRErrorLevel.LevelL;
            builder.CodeText = lCodetext;
            builder.Display2DText = "My Text";
            Bitmap lBmp = builder.GenerateBarCodeImage();
            lBmp.Save(dataDir + "MultiECIModeInExtendedMode_out.bmp", ImageFormat.Bmp);
        }
    }
}