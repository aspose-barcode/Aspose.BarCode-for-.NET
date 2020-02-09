using System;
using System.Drawing;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
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
    class GenerateAndRecognizeUTF8Characters
    {
        public static void Run()
        {
            try
            {
                // ExStart:GenerateAndRecognizeUTF8Characters
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_Recognition();

                // Generate the barcode
                Bitmap imgBarcode = null;
                BarcodeGenerator barCodeGenerator = new BarcodeGenerator(EncodeTypes.MacroPdf417);
                
                // Set the codetext by converting it into unicode byte array
                barCodeGenerator.CodeText = "منحة";
                barCodeGenerator.Parameters.Barcode.Pdf417.CodeTextEncoding = Encoding.Unicode;

                imgBarcode = barCodeGenerator.GenerateBarCodeImage();
                imgBarcode.Save(dataDir + "GenerateAndRecognizeUTF8Characters_out.png");

                // Recognize the above barcode
                BarCodeReader reader = new BarCodeReader(dataDir + "GenerateAndRecognizeUTF8Characters_out.png");
                while (reader.Read())
                {
                    Encoding unicode = Encoding.Unicode;
                   
                    // Get the characters array from the bytes
                    char[] unicodeChars = new char[unicode.GetCharCount(reader.GetCodeBytes(), 0, reader.GetCodeBytes().Length)];
                    unicode.GetChars(reader.GetCodeBytes(), 0, reader.GetCodeBytes().Length, unicodeChars, 0);
                    
                    // Build unicode string
                    string strCodeText = new string(unicodeChars);
                    Console.WriteLine(strCodeText);
                }
                reader.Close();
                // ExEnd:GenerateAndRecognizeUTF8Characters
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}