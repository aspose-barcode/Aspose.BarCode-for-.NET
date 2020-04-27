using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GenerateAPatchCode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            GeneratePatchCode(dataDir);
            GenerateWholePage(dataDir);
        }

        private static void GeneratePatchCode(string dataDir)
        {
            // ExStart:GeneratePatchCode                
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.PatchCode, "Patch T");
            generator.Save(dataDir + "patch.bmp");
            // ExEnd:GeneratePatchCode
        }

        private static void GenerateWholePage(string dataDir)
        {
            // ExStart:GenerateWholePage                
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.PatchCode, "Patch T");
            generator.Parameters.ImageWidth.Millimeters = 150;          // in millimeters
            generator.Parameters.Barcode.Padding.Top.Pixels = 0.5f;     // make the same small margins
            generator.Parameters.Barcode.Padding.Right.Pixels = 0.5f;
            generator.Parameters.Barcode.Padding.Left.Pixels = 0.5f;
            generator.Parameters.Barcode.Padding.Bottom.Pixels = 0.5f;

            // to hide codetext
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;

            Image topImg = generator.GenerateBarCodeImage();
            generator.Parameters.RotationAngle = 90;

            Image leftImg = generator.GenerateBarCodeImage();
            generator.Parameters.RotationAngle = 90;
            
            Image bottomImg = generator.GenerateBarCodeImage();
            generator.Parameters.RotationAngle = 90;
            
            Image rigthtImg = generator.GenerateBarCodeImage();

            Bitmap frameImg = new Bitmap(topImg.Width, rigthtImg.Height + 2 * topImg.Height);

            // Initialize graphics object from the image
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(frameImg))
            {
                graphics.DrawImage(topImg, 0, 0);
                graphics.DrawImage(leftImg, 0, topImg.Height);
                graphics.DrawImage(bottomImg, 0, topImg.Height + leftImg.Height);
                graphics.DrawImage(rigthtImg, topImg.Width - rigthtImg.Width, topImg.Height);
            }

            // save Patch code frame
            frameImg.Save(dataDir + "output.jpg");
            // ExEnd:GenerateWholePage
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "output.jpg");
        }
    }
}
