using System;
using System.Drawing.Imaging;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class ManagePDF417Barcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.Pdf417;

            // set Pdf417 Error correction level
            barCodeBuilder.Pdf417ErrorLevel = Pdf417ErrorLevel.Level8;
            
            // Set Pdf417 Compaction Mode to Text
            barCodeBuilder.Pdf417CompactionMode = Pdf417CompactionMode.Text;

            // set CodeText for barcode
            barCodeBuilder.CodeText = "1234567890";
            
            barCodeBuilder.Save(dataDir + "ManagePDF417Barcode_out.bmp", ImageFormat.Bmp);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "Datamatrixbarcode_out.bmp");
        }
    }
}
