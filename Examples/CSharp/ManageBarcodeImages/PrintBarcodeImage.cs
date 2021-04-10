using System.Drawing.Printing;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class PrintBarcodeImage
    {
        public static void Run()
        {
            // ExStart:PrintBarcodeImage       

            //draw image
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (printSender, printEvent) =>
            {
                using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567890"))
                    printEvent.Graphics.DrawImage(generator.GenerateBarCodeImage(), 0, 0);
            };

            //print
            doc.Print();
            // ExEnd:PrintBarcodeImage       
        }
    }
}
