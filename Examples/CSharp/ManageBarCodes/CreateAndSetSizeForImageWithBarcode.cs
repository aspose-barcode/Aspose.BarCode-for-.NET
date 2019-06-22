using System;
using System.Drawing;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateAndSetSizeForImageWithBarcode
    {
        public static void Run()
        {
            try
            {
                // ExStart:CreateAndSetSizeForImageWithBarcode
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageBarCodes();

                // Generate the barcode and set code text, symbology type
                BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "One thing 2 thing");

                // Set the code text location,  graphics unit and margins
                generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                generator.Parameters.Barcode.Padding.Bottom.Pixels = 0;
                generator.Parameters.Barcode.Padding.Top.Pixels = 0;
                generator.Parameters.Barcode.Padding.Left.Pixels = 0;
                generator.Parameters.Barcode.Padding.Right.Pixels = 0;
                
                // Get Bitmap with exact barcode only
                Bitmap bmp = generator.GenerateBarCodeImage();

                bmp.Save(dataDir +  "CreateAndSetSizeForImageWithBarcode_out.Png");
                // ExEnd:CreateAndSetSizeForImageWithBarcode
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}