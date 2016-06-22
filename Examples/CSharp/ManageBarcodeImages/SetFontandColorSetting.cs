using System.IO;
using System;
using System.Drawing;
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
    class SetFontandColorSetting
    {
        public static void Run()
        {
            //ExStart:ManSetFontandColorSettingageCaption
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            barCodeBuilder.CaptionAbove.TextAlign = StringAlignment.Near;
            barCodeBuilder.CaptionAbove.Text = "Aspose.Demo";
            barCodeBuilder.CaptionAbove.Visible = true;
            barCodeBuilder.CaptionAbove.Font = new System.Drawing.Font("Pristina", 14f);
            barCodeBuilder.CaptionAbove.ForeColor = Color.OrangeRed;

            barCodeBuilder.CaptionBelow.TextAlign = StringAlignment.Far;
            barCodeBuilder.CaptionBelow.Text = "Aspose.Demo";
            barCodeBuilder.CaptionBelow.Visible = true;
            barCodeBuilder.CaptionBelow.Font = new System.Drawing.Font("Pristina", 14f);
            barCodeBuilder.CaptionBelow.ForeColor = Color.OrangeRed;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "SetFontandColorSetting.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            // ExEnd:ManageCaption            
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir);
        }
    }
}


