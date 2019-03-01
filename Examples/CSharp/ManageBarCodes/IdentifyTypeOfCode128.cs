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
    class IdentifyTypeOfCode128
    {
        public static void Run()
        {
            // ExStart:IdentifyTypeOfCode128 

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create an instance of BarCodeReader class
            // Set file path
            // Set the recognition type
            using (Aspose.BarCode.BarCodeRecognition.BarCodeReader reader = new Aspose.BarCode.BarCodeRecognition.BarCodeReader("1bc.png", Aspose.BarCode.BarCodeRecognition.DecodeType.Code128))
            {
                // Perform read operation
                if (reader.Read())
                {
                    // Create an array of Code128DataPortion class
                    // Call the GetCode128DataPortions method
                    Aspose.BarCode.BarCodeRecognition.Code128DataPortion[] code128DataPortions = reader.GetCode128DataPortions();

                    // Execute Loop for each Code128DataPortion instance
                    foreach (Aspose.BarCode.BarCodeRecognition.Code128DataPortion code128DataPortion in code128DataPortions)
                    {
                        // Display the subtype and data
                        System.Console.WriteLine("Code128SubType {0}", code128DataPortion.Code128SubType);
                        System.Console.WriteLine("Data {0}", code128DataPortion.Data);
                    }
                }
            }

            // ExEnd:IdentifyTypeOfCode128 
        }
    }
}