using System.IO;
using System;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SaveBarcodeImageToStreams
    {
        public static void Run()
        {
            //ExStart:SaveBarcodeImageToStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Create a memory stream object that would store barcode image in binary form
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();

            // Call save method of BarCodeImage to store Png barcode image to memory stream
            barCodeBuilder.BarCodeImage.Save(dataDir + mStream + ".png", System.Drawing.Imaging.ImageFormat.Png);
            //ExEnd:SaveBarcodeImageToStreams
        }
    }
}
