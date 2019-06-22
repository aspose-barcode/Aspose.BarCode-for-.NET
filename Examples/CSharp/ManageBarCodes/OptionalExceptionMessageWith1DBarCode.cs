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
    class OptionalExceptionMessageWith1DBarCode
    {
        public static void Run()
        {
            // ExStart:OptionalExceptionMessageWith1DBarCode
            // Instantiate BarcodeGenerator  object
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.EAN13, "348503498549085409");
            try
            {
                // Error message will not been thrown in case of false, default value is also false and Get barcode image
                generator.Parameters.Barcode.ThrowExceptionWhenCodeTextIncorrect = true;               
                Bitmap bitmap = generator.GenerateBarCodeImage();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception must be thrown, {0}", ex.Message);
            }
            // ExEnd:OptionalExceptionMessageWith1DBarCode
        }
    }
}