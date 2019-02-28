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
    class CreateEnCodeDatamatrixBarCode
    {
        public static void Run()
        {
            //ExStart:CreateEnCodeDatamatrixBarCode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.DataMatrix, "This is the data to be encoded");

            // Set Data Matrix EncodeMode 
            generator.DataMatrix.EncodeMode = DataMatrixEncodeMode.ASCII;
            generator.Save(dataDir + "ManagePDF417Barcode_out.bmp", BarCodeImageFormat.Bmp);
            //ExEnd:CreateEnCodeDatamatrixBarCode
        }
    }
}

