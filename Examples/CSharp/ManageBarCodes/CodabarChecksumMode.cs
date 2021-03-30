using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CodabarChecksumMode
    {
        public static void Run()
        {
            //ExStart:CodabarChecksumMode 
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            
            //Generation
            //Instantiate BarcodeGenerator  object
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Codabar);

            //Set the Code text for the barcode
            generator.CodeText = "1234567890";

            //Set the EnableChecksum property to yes
            generator.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Yes;

            //Set the CodabarChecksumMode
            generator.Parameters.Barcode.Codabar.CodabarChecksumMode = Aspose.BarCode.Generation.CodabarChecksumMode.Mod10;

            //Save the image on the system
            generator.Save("Codabar_Mod10.png");

            //Recognition
            //Initialize reader object
            using (Aspose.BarCode.BarCodeRecognition.BarCodeReader reader = new Aspose.BarCode.BarCodeRecognition.BarCodeReader("Codabar_Mod10.png", Aspose.BarCode.BarCodeRecognition.DecodeType.Codabar))
            {
                //Set ChecksumValidation property of the reader to On
                reader.ChecksumValidation = Aspose.BarCode.BarCodeRecognition.ChecksumValidation.On;
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    //Get code text
                    Console.WriteLine("BarCode Type: " + result.CodeType);
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);

                    //Get checksum value
                    System.Console.WriteLine("Checksum:" + result.Extended.OneD.CheckSum);
                }
            }


            // ExEnd:CodabarChecksumMode 
        }
    }
}