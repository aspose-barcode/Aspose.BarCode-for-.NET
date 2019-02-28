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
    class CodabarChecksumMode
    {
        public static void Run()
        {
            // ExStart:ChecksumSupplementData 
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            
            //Generation
            //Instantiate BarCodeGenerator object
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Codabar);

            //Set the Code text for the barcode
            generator.CodeText = "1234567890";

            //Set the EnableChecksum property to yes
            generator.Checksum.Enable = EnableChecksum.Yes;

            //Set the CodabarChecksumMode
            generator.Codabar.ChecksumMode = Aspose.BarCode.CodabarChecksumMode.Mod10;

            //Save the image on the system
            generator.Save("Codabar_Mod10.png");

            //Recognition
            //Initialize reader object
            using (Aspose.BarCode.BarCodeRecognition.BarCodeReader reader = new Aspose.BarCode.BarCodeRecognition.BarCodeReader("Codabar_Mod10.png", Aspose.BarCode.BarCodeRecognition.DecodeType.Codabar))
            {
                //Set ChecksumValidation property of the reader to On
                reader.ChecksumValidation = Aspose.BarCode.BarCodeRecognition.ChecksumValidation.On;
                while (reader.Read())
                {
                    //Get code text
                    System.Console.WriteLine("{0}:{1}", reader.GetCodeType(), reader.GetCodeText());

                    //Get checksum value
                    System.Console.WriteLine("Checksum:" + reader.GetCheckSum());
                }
            }
            
            
            // ExEnd:ChecksumSupplementData 
        }
    }
}