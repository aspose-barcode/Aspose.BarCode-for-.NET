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
            // ExStart:ChecksumSupplementData 

            //Instantiate BarCodeBuilder object
            Aspose.BarCode.BarCodeBuilder builder = new Aspose.BarCode.BarCodeBuilder();

            //Set the Code text for the barcode
            builder.CodeText = "(01)98898765432106(3202)012345(15)991231";

            //Set the symbology type to Code128
            builder.EncodeType = Aspose.BarCode.Generation.EncodeTypes.DatabarExpandedStacked;

            //Set the cloumn property to define segments per row
            builder.Columns = 6;

            //Save the image
            builder.Save("6segmets.png");
            
            // ExEnd:ChecksumSupplementData 
        }
    }
}