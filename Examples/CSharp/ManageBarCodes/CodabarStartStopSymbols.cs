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
    class CodabarStartStopSymbols
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("11112222333344", EncodeTypes.Codabar)
            {
                // Set the codabar start symbol to A and stop symbol to D
                CodabarStartSymbol = CodabarSymbol.A,
                CodabarStopSymbol = CodabarSymbol.D
            };           
            builder.Save(dataDir + "Coabar-start-stop-symbols_out.png");
        }
    }
}