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
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder
            {
                CaptionAbove =
                {
                    TextAlign = StringAlignment.Near,
                    Text = "Aspose.Demo",
                    Visible = true,
                    Font = new Font("Pristina", 14f),
                    ForeColor = Color.OrangeRed
                }
            };

            barCodeBuilder.CaptionBelow.TextAlign = StringAlignment.Far;
            barCodeBuilder.CaptionBelow.Text = "Aspose.Demo";
            barCodeBuilder.CaptionBelow.Visible = true;
            barCodeBuilder.CaptionBelow.Font = new Font("Pristina", 14f);
            barCodeBuilder.CaptionBelow.ForeColor = Color.OrangeRed;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "SetFontandColorSetting_out.jpeg", ImageFormat.Jpeg);
        }
    }
}