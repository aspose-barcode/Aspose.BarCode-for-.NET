using System;
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
    class ManagePDF417Barcode
    {
        public static void Run()
        {
            //ExStart:ManagePDF417Barcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Pdf417, "1234567890");

            // Set Pdf417 Error correction level, Compaction Mode to Text and CodeText for barcode
            generator.Parameters.Barcode.Pdf417.Pdf417ErrorLevel = Pdf417ErrorLevel.Level8;
            generator.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Text;
            generator.CodeText = "1234567890";

            generator.Save(dataDir + "ManagePDF417Barcode_out.bmp", BarCodeImageFormat.Bmp);
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "Datamatrixbarcode_out.bmp");
            //ExEnd:ManagePDF417Barcode
        }
    }
}
