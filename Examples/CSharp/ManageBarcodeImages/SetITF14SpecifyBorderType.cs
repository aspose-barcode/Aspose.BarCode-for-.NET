using System.Drawing;
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
    class SetITF14SpecifyBorderType
    {
        public static void Run()
        {
            // ExStart:SetITF14SpecifyBorderType                       
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.ITF14, "00850006000227");

            // Set ITF14 Barcode Border Type
            generator.ITF.BorderType = ITF14BorderType.FrameOut;

            // Set Font
            generator.CodeTextStyle.Font.FamilyName = "OCR B Std";
            generator.CodeTextStyle.Font.Size.Point = 8;

            // Set xDimension
            generator.XDimension.Millimeters = 0.495f;

            // Set Bars Height
            generator.BarHeight.Millimeters = 12.7f;

            // Specify space between characters
            generator.CodeTextStyle.Space.Millimeters = 0.5f;

            // Define resolution
            generator.Resolution = 1200.0f;

            generator.Save(dataDir + "ITF14_Border_Type_Frame_out.png", BarCodeImageFormat.Png);
            // ExEnd:SetITF14SpecifyBorderType                       
        }
    }
}

