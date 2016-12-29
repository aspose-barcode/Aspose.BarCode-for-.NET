using System.Drawing.Imaging;
using System.IO;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SaveBarcodeImageToStreams
    {
        public static void Run()
        {
            // ExStart:SaveBarcodeImageToStreams       
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128);

            // Create a memory stream object that would store barcode image in binary form
            MemoryStream mStream = new MemoryStream();

            // Call save method of BarCodeImage to store Png barcode image to memory stream
            barCodeBuilder.BarCodeImage.Save(dataDir + mStream + "_out.png", ImageFormat.Png);
            // ExEnd:SaveBarcodeImageToStreams       
        }
    }
}
