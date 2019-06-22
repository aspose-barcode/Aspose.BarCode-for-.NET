using Aspose.BarCode.Generation;
using System.Drawing;
using System.Drawing.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SetFontandColorSetting
    {
        public static void Run()
        {
            // ExStart:SetFontandColorSetting                       
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Code128);

            generator.Parameters.CaptionAbove.Visible = true;
            generator.Parameters.CaptionAbove.Text = "Aspose";
            generator.Parameters.CaptionAbove.Alignment = TextAlignment.Center;
            generator.Parameters.CaptionAbove.TextColor = Color.Red;
            generator.Parameters.CaptionAbove.Font.FamilyName = "Pristina";
            generator.Parameters.CaptionAbove.Font.Size.Point = 14;

            generator.Parameters.CaptionBelow.Alignment = TextAlignment.Center;
            generator.Parameters.CaptionBelow.Text = "Aspose.Demo";
            generator.Parameters.CaptionBelow.Visible = true;
            generator.Parameters.CaptionBelow.Font.FamilyName = "Pristina";
            generator.Parameters.CaptionBelow.Font.Size.Point = 14;
            generator.Parameters.CaptionBelow.TextColor = Color.OrangeRed;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "SetFontandColorSetting_out.jpeg", BarCodeImageFormat.Jpeg);
            // ExEnd:SetFontandColorSetting                       
        }
    }
}