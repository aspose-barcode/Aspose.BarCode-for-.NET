using System;
using System.Drawing.Imaging;
using System.Text;
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
    class CustomEncodingModeInDataMatrix
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.DataMatrix;

            // Set Data Matrix EncodeMode to Custom
            barCodeBuilder.DataMatrixEncodeMode = DataMatrixEncodeMode.Custom;

            // Set CodeText Encoding Property 
            barCodeBuilder.CodeTextEncoding = Encoding.UTF8;

            // Set CodeText for barcode          
            barCodeBuilder.CodeText = "Г¶Г¤ГјГ©Г ГЁ";

            barCodeBuilder.Save(dataDir + "CustomEncodingModeInDataMatrix_out.bmp", ImageFormat.Bmp);
        }
    }
}

