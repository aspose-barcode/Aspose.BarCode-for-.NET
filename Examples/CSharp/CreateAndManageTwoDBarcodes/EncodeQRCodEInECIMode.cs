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
    class EncodeQRCodEInECIMode
    {
        public static void Run()
        {
            //ExStart:EncodeQRCodEInECIMode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // initialize a BarCodeBuilder class object and Set its CodeText & Symbology Type 
            BarCodeBuilder builder = new BarCodeBuilder("12345TEXT", EncodeTypes.QR);

            // Set encoding mode, ForceQR (default) for standard QR, ECI encoding type, error correction level
            builder.QREncodeMode = QREncodeMode.ECIEncoding;
            builder.QREncodeType = QREncodeType.ForceQR;
            builder.ECIEncoding = ECIEncodings.UTF8;
            builder.QRErrorLevel = QRErrorLevel.LevelL;

            // Get barcode image Bitmap & Save QR code
            Bitmap lBmp = builder.GenerateBarCodeImage();
            lBmp.Save(dataDir + "EncodeQRCodEInECIMode_out.bmp", ImageFormat.Bmp);
            //ExEnd:EncodeQRCodEInECIMode
        }
    }
}
