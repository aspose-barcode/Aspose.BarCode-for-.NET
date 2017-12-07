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
    class SettingQRVersion
    {
        public static void Run()
        {
            //ExStart:EncodeQRCode
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate BarCodeBuilder object
            Aspose.BarCode.BarCodeBuilder builder = new Aspose.BarCode.BarCodeBuilder();

            // Set the Code text for the barcode
            builder.CodeText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Set the symbology type to QR
            builder.EncodeType = Aspose.BarCode.Generation.EncodeTypes.QR;

            // Set the error level
            builder.QRErrorLevel = Aspose.BarCode.QRErrorLevel.LevelQ;

            // Set the QR barcode version number
            builder.QRVersion = Aspose.BarCode.QRVersion.Version10;

            //Save the image
            builder.Save("qr_version10_errorQ.png");
            
            //ExEnd:EncodeQRCode
        }
    }
}