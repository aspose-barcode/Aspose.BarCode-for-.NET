using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.RecognitionExamples
{
    class BarcodeWithChecksumValue
    {
        public static void Run()
        {
            // ExStart:ChecksumSupplementData 

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Recognition();

            //Initialize reader object
            using (Aspose.BarCode.BarCodeRecognition.BarCodeReader reader = new Aspose.BarCode.BarCodeRecognition.BarCodeReader("error5.jpg", Aspose.BarCode.BarCodeRecognition.DecodeType.EAN13))
            {
                while (reader.Read())
                {
                    //Get code text by passing TRUE to get the Barcode along with checksum value
                    System.Console.WriteLine("{0}: {1}", reader.GetCodeType(), reader.GetCodeText(true));
                }
            }
            
            // ExEnd:ChecksumSupplementData 
        }
    }
}