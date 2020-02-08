using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class GenerateMultipleBarcodesOnSingleImage
    {
        public static void Run()
        {
            // ExStart:GenerateMultipleBarcodesOnSingleImage
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_TechnicalArticles();

            Dictionary<string, BaseEncodeType> collection = new Dictionary<string, BaseEncodeType>();
            collection.Add("ONE123", EncodeTypes.Code39Standard);
            collection.Add("Process Collection", EncodeTypes.DataMatrix);
            collection.Add("Dictionary Collection", EncodeTypes.QR);
            collection.Add("X06712AT", EncodeTypes.Code128);
            collection.Add("979026000043", EncodeTypes.EAN13);
            collection.Add("Aztec BarCode", EncodeTypes.Aztec);

            List<Bitmap> images = new List<Bitmap>();

            foreach (KeyValuePair<string, BaseEncodeType> pair in collection)
            {
                BarcodeGenerator builder = new BarcodeGenerator(pair.Value, pair.Key);
                images.Add(builder.GenerateBarCodeImage());
            }

            int maxWidth = int.MinValue;
            int sumHeight = 0;
            foreach (Bitmap bmp in images)
            {
                sumHeight += bmp.Height;
                if (maxWidth < bmp.Width)
                    maxWidth = bmp.Width;
            }

            const int offset = 10;
            Bitmap resultBitmap = new Bitmap(maxWidth + offset * 2, sumHeight + offset * images.Count);
            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                g.Clear(Color.White);

                int yPosition = offset;
                for (int i = 0; i < images.Count; ++i)
                {
                    Bitmap currentBitmap = images[i];
                    g.DrawImage(currentBitmap, offset, yPosition);
                    yPosition += currentBitmap.Height + offset;
                }
            }

            resultBitmap.Save(dataDir + "barcodes_out.png", ImageFormat.Png);
            // ExEnd:GenerateMultipleBarcodesOnSingleImage
            Console.WriteLine(Environment.NewLine + "Generating Multiple Barcodes On A Single Image Finished.");
        }
    }
}
