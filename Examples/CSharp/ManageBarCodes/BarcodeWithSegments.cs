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
    class BarcodeWithSegments
    {
        public static void Run()
        {
            // ExStart:BarcodeWithSegments 

            //Instantiate BarCodeGenerator object
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.DatabarExpandedStacked);

            //Set the Code text for the barcode
            generator.CodeText = "(01)98898765432106(3202)012345(15)991231";

            //Save the image
            generator.Save("6segmets.png");

            // ExEnd:BarcodeWithSegments 
        }
    }
}