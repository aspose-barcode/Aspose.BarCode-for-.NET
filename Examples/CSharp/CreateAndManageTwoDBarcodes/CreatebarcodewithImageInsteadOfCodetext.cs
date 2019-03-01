using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class CreateBarCodeWithImageInsteadOfCodeText
    {
        public static void Run()
        {
            // ExStart:CreateBarCodeWithImageInsteadOfCodeText
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create an instance of BarCodeBuilder class
            // Set the barcode text
            // Set the barcode symbology 
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.EAN13, "123456789012"))
            {
                // Generate Barcode image and store it in a Bitmap
                using (System.Drawing.Bitmap barcode = generator.GenerateBarCodeImage())
                {
                    // Load the logo/other image as Bitmap
                    using (System.Drawing.Bitmap picture = (System.Drawing.Bitmap)System.Drawing.Image.FromFile(@"path_to_your_picture.png"))
                    {
                        // Create a new empty image with new Calculated height &amp; width
                        using (System.Drawing.Bitmap output = new System.Drawing.Bitmap(System.Math.Max(barcode.Width, picture.Width), barcode.Height + picture.Height))
                        {
                            // Get the Graphics object9
                            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(output))
                            {
                                // Clear the canvas 
                                g.Clear(System.Drawing.Color.White);

                                // Draw the primary image (barcode image) on the canvas
                                g.DrawImage(picture, new System.Drawing.PointF(0, 0));

                                // Draw the second image (logo image) on the canvas inside the barcode image
                                g.DrawImage(barcode, new System.Drawing.PointF(0, picture.Height));
                            }
                            output.Save(dataDir + "output.jpg");
                        }
                    }
                }
            }

            // ExEnd:CreateBarCodeWithImageInsteadOfCodeText
        }
    }
}
