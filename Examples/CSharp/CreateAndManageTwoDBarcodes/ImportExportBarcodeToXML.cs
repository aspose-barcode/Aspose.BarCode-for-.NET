using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class ImportExportBarcodeToXML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            ExportBarcodeToXML(dataDir);
            ImportBarcodeFromXML(dataDir);
        }

        public static void ExportBarcodeToXML(string dataDir)
        {
            // ExStart:ExportBarcodeToXML
            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "this is some test code text. \n Second line \n third line.");

            // Set width and height
            generator.Parameters.Barcode.XDimension.Millimeters = 0.6f;
            generator.Parameters.Barcode.BarHeight.Millimeters = 1.2f;

            string xmlFile = dataDir + "barcode.xml";
            generator.ExportToXml(xmlFile);
            // ExEnd:ExportBarcodeToXML
            Console.WriteLine(Environment.NewLine + "Barcode exported to XML and saved at " + dataDir);
        }

        public static void ImportBarcodeFromXML(string dataDir)
        {
            // ExStart:ImportBarcodeFromXML
            string xmlFile = dataDir + "barcode.xml";
            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarcodeGenerator generator = BarcodeGenerator.ImportFromXml(xmlFile);
            generator.Save(dataDir + "barcode_xml_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:ImportBarcodeFromXML
            Console.WriteLine(Environment.NewLine + "Imported barcode saved at " + dataDir);
        }

    }
}
