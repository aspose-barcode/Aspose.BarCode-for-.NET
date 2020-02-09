using System;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.RecognitionExamples
{
    class ReadBarcodeFromTIFFImages
    {
        public static void Run()
        {
            try
            {
                // ExStart:ReadBarcodeFromTIFFImages
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_Recognition();
                var img = Image.FromFile(dataDir + "tiffImage.tif");
                int totalFrame = img.GetFrameCount(FrameDimension.Page);

                // Feed the pages to BarCodeReader one by one
                for (int i = 0; i < totalFrame; i++)
                {
                    // Set the active page and feed it to the BarCodeReader
                    var w = img.SelectActiveFrame(FrameDimension.Page, i);
                    var bitmap = new Bitmap(img);
                    BarCodeReader reader = new BarCodeReader(bitmap, DecodeType.AllSupportedTypes);
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetCodeText() + " " + reader.GetCodeType());
                    }
                }
                // ExEnd:ReadBarcodeFromTIFFImages
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}