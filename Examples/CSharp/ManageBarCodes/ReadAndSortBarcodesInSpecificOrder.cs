using System;
using System.Collections.Generic;
using System.Drawing;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class ReadAndSortBarcodesInSpecificOrder
    {
        // ExStart:ReadAndSortBarcodesInSpecificOrder
        public static void Run()
        {
           
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            List<FoundBarCodes> found = new List<FoundBarCodes>();
            using (BarCodeReader reader = new BarCodeReader(dataDir + "tiffImage.tif", DecodeType.Code128))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    found.Add(new FoundBarCodes(result.CodeText, result.Region));
            }
            found.Sort(new FoundComparator());
            int i = 1;
            foreach (FoundBarCodes barcode in found)
            {
                Console.WriteLine("Codetext ( " + i + " ): " + barcode.CodeText);
                Console.WriteLine("Top left coordinates: X = " + barcode.region.Points[0].X + ", Y = " + barcode.region.Points[0].Y);
                Console.WriteLine("Bottom left coordinates: X = " + barcode.region.Points[1].X + ", Y = " + barcode.region.Points[1].Y);
                Console.WriteLine("Bottom right coordinates: X = " + barcode.region.Points[2].X + ", Y = " + barcode.region.Points[2].Y);
                Console.WriteLine("Top right coordinates: X = " + barcode.region.Points[3].X + ", Y = " + barcode.region.Points[3].Y);
                Console.WriteLine();
                i++;
            }
        }

        public struct FoundBarCodes
        {
            public readonly string CodeText;
            public readonly BarCodeRegionParameters region;
            public FoundBarCodes(string text, BarCodeRegionParameters reg)
            {
                CodeText = text;
                region = reg;
            }
        }

        public class FoundComparator : IComparer<FoundBarCodes>
        {
            public int Compare(FoundBarCodes found1, FoundBarCodes found2)
            {
                Point[] found1Points = found1.region.Points;
                Point[] found2Points = found2.region.Points;
                Point found1XyMin = new Point(int.MaxValue, int.MaxValue);
                Point found2XyMin = new Point(int.MaxValue, int.MaxValue);
                foreach (Point p in found1Points)
                    if (p.X < found1XyMin.X && p.Y < found1XyMin.Y)
                    {
                        found1XyMin.X = p.X;
                        found1XyMin.Y = p.Y;
                    }
                foreach (Point p in found2Points)
                    if (p.X < found2XyMin.X && p.Y < found2XyMin.Y)
                    {
                        found2XyMin.X = p.X;
                        found2XyMin.Y = p.Y;
                    }
                if (found1XyMin.X < found2XyMin.X && found1XyMin.Y < found2XyMin.Y)
                    return -1;
                if (found1XyMin.X > found2XyMin.X && found1XyMin.Y > found2XyMin.Y)
                    return 1;
                if (found1XyMin.Y < found2XyMin.Y)
                    return -1;
                if (found1XyMin.Y > found2XyMin.Y)
                    return 1;
                return 0;
            }
        }
        // ExEnd:ReadAndSortBarcodesInSpecificOrder
    }
}