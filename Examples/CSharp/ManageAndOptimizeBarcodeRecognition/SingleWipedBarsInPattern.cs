using Aspose.BarCode.BarCodeRecognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class SingleWipedBarsInPattern
    {
        public static void Run()
        {
            try
            {
                // ExStart:SingleWipedBarsInPattern
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Initialize the BarCodeReader object and  Set recognition mode
                using (BarCodeReader reader = new BarCodeReader(@"file.tiff", DecodeType.Code128))
                {
                    reader.QualitySettings.AllowOneDWipedBarsRestoration = true;
                    List<string> lCodetexts = new List<string>();
                    while (reader.Read())
                    {
                        lCodetexts.Add(reader.GetCodeText());
                        Console.WriteLine(reader.GetCodeText());
                    }
                }
                // ExEnd:SingleWipedBarsInPattern
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
