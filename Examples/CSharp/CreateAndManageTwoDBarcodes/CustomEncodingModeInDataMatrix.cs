using System.Drawing.Imaging;
using System.Text;
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
    class CustomEncodingModeInDataMatrix
    {
        public static void Run()
        {
            //ExStart:CustomEncodingModeInDataMatrix
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.DataMatrix, "Г¶Г¤ГјГ©Г ГЁ");

            // Set Data Matrix EncodeMode to Custom and CodeText Encoding Property 
            generator.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Custom;
            generator.Parameters.Barcode.DataMatrix.CodeTextEncoding = Encoding.UTF8;
            generator.Save(dataDir + "CustomEncodingModeInDataMatrix_out.bmp", BarCodeImageFormat.Bmp);
            //ExEnd:CustomEncodingModeInDataMatrix
        }
    }
}

