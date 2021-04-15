using System;
using System.Threading;
using System.Diagnostics;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class OptimizingBarCodeRecognitionProcess
    {
        public static void Run()
        {
            // ExStart:OptimizingBarCodeRecognitionProcess

            ManualAmmountOfCores(4);

            AutoAmmountOfCores();

            // ExEnd:OptimizingBarCodeRecognitionProcess
        }

        public static void ManualAmmountOfCores(int RequiredCores)
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Start the stopwatch
                Stopwatch sw = new Stopwatch();
                sw.Start();

                // Define ThreadPool options
                int workerThreads;
                int completionPortThreads;
                ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
                ThreadPool.SetMaxThreads(Math.Max(RequiredCores * 2, workerThreads), completionPortThreads);
                ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
                ThreadPool.SetMinThreads(Math.Max(RequiredCores * 2, workerThreads), completionPortThreads);

                // Use manual ammount of allowed cores for whole recognition engine
                BarCodeReader.ProcessorSettings.UseAllCores = false;
                BarCodeReader.ProcessorSettings.UseOnlyThisCoresCount = RequiredCores;
                BarCodeReader.ProcessorSettings.MaxAdditionalAllowedThreads = RequiredCores;

                // Perform the BarCode recognition task Initialize the BarCodeReader object
                using (BarCodeReader reader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code128))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        Console.WriteLine(" Code Text: " + result.CodeText + " Type: " + result.CodeType);
                    }
                }

                // Stop the stopwatch
                sw.Stop();
                // Write the Elapsed time to console
                Console.WriteLine("Elapsed: " + sw.Elapsed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }

        public static void AutoAmmountOfCores()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Start the stopwatch
                Stopwatch sw = new Stopwatch();
                sw.Start();

                // Define ThreadPool options
                int workerThreads;
                int completionPortThreads;
                ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
                ThreadPool.SetMaxThreads(Math.Max(Environment.ProcessorCount * 4, workerThreads), completionPortThreads);
                ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
                ThreadPool.SetMinThreads(Math.Max(Environment.ProcessorCount * 4, workerThreads), completionPortThreads);

                // Use automatic ammount of allowed cores for task which is simular to Environment.ProcessorCount
                // and max ammount of used threads for whole recognition engine is Environment.ProcessorCount * 2
                BarCodeReader.ProcessorSettings.UseAllCores = true;
                BarCodeReader.ProcessorSettings.MaxAdditionalAllowedThreads = Environment.ProcessorCount * 2;

                // Perform the BarCode recognition task Initialize the BarCodeReader object
                using (BarCodeReader reader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code128))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        Console.WriteLine(" Code Text: " + result.CodeText + " Type: " + result.CodeType);
                    }
                }

                // Stop the stopwatch
                sw.Stop();
                // Write the Elapsed time to console
                Console.WriteLine("Elapsed: " + sw.Elapsed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
