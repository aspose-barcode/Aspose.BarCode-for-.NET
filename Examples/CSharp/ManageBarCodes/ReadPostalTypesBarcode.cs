using Aspose.BarCode.BarCodeRecognition;
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
    class ReadPostalTypesBarcode
    {
        public static void Run()
        {
            //ExStart:ReadPostalTypesBarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            using (BarCodeReader reader = new BarCodeReader(dataDir + "test.png", DecodeType.PostalTypes))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    Console.WriteLine(result.CodeType.ToString() + " " + result.CodeText);
                }
            }
            //ExEnd: ReadPostalTypesBarcode
        }
    }
}
