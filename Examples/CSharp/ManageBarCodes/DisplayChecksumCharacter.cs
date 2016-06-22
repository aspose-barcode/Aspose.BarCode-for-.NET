using System;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class DisplayChecksumCharacter
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            //ExStart:DisplayChecksumCharacter
            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("0123456789", Symbology.Code39Standard);
          
            // Always show checksum on image
            barCodeBuilder.AlwaysShowChecksum = true;

            // Save file to disk
            barCodeBuilder.Save(dataDir + "DisplayChecksumCharacter_out.png");

            //ExEnd:DisplayChecksumCharacter
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "DisplayChecksumCharacter.png");
        }
    }
}
