using System;
using System.Drawing;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class ReadBarcodeInWPF
    {
        internal class LazyLicenseInitialization
        {
            private static LazyLicenseInitialization instance = new LazyLicenseInitialization();
            private LazyLicenseInitialization()
            {
                //code setting license
                //(new Aspose.BarCode.License()).SetLicense(@"Aspose.Total.NET.lic");
            }
            //required to make LazyLicenseInitialization visible to VM
            //and do single run code in LazyLicenseInitialization() 
            internal static void Init()
            { }
        }
        
        public static void Run()
        {
            try
            {
                // ExStart:ReadBarcodeInWPF
                
                //once run license intialization
                LazyLicenseInitialization.Init();

                //generate our image source, can be obtained from other variants
                Bitmap imageSourceForRecognition = (new BarcodeGenerator(EncodeTypes.Code128, "12345678")).GenerateBarCodeImage();

                //read our barcode
                using (BarCodeReader reader = new BarCodeReader(imageSourceForRecognition, DecodeType.Code128))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        // Read symbology type and code text
                        Console.WriteLine("Symbology Type: " + result.CodeType);
                        Console.WriteLine("CodeText: " + result.CodeText);
                    }
                }


                // ExEnd:ReadBarcodeInWPF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
