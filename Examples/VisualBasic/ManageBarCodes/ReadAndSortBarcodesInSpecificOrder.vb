Imports System.Collections.Generic
Imports System.Drawing
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ReadAndSortBarcodesInSpecificOrder
        ' ExStart:ReadAndSortBarcodesInSpecificOrder
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
                Dim found As New List(Of FoundBarCodes)()
                Using reader As New BarCodeReader(dataDir & "tiffImage.tif", DecodeType.Code128)
                    While reader.Read()
                        found.Add(New FoundBarCodes(reader.GetCodeText(), reader.GetRegion()))
                    End While
                End Using
                found.Sort(New FoundComparator())
                Dim i As Integer = 1
                For Each barcode As FoundBarCodes In found
                    Console.WriteLine("Codetext ( " & i & " ): " & barcode.CodeText)
                    Console.WriteLine(("Top left coordinates: X = " + barcode.region.Points(0).X & ", Y = ") + barcode.region.Points(0).Y)
                    Console.WriteLine(("Bottom left coordinates: X = " + barcode.region.Points(1).X & ", Y = ") + barcode.region.Points(1).Y)
                    Console.WriteLine(("Bottom right coordinates: X = " + barcode.region.Points(2).X & ", Y = ") + barcode.region.Points(2).Y)
                    Console.WriteLine(("Top right coordinates: X = " + barcode.region.Points(3).X & ", Y = ") + barcode.region.Points(3).Y)
                    Console.WriteLine()
                    i += 1
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub

        Friend Class FoundComparator
            Implements IComparer(Of FoundBarCodes)
            Public Function Compare(ByVal found1 As FoundBarCodes, ByVal found2 As FoundBarCodes) As Integer Implements IComparer(Of FoundBarCodes).Compare
                Dim found1Points As Point() = found1.region.Points
                Dim found2Points As Point() = found2.region.Points
                Dim found1XyMin As New Point(Integer.MaxValue, Integer.MaxValue)
                Dim found2XyMin As New Point(Integer.MaxValue, Integer.MaxValue)
                For Each p As Point In found1Points
                    If p.X < found1XyMin.X AndAlso p.Y < found1XyMin.Y Then
                        found1XyMin.X = p.X
                        found1XyMin.Y = p.Y
                    End If
                Next
                For Each p As Point In found2Points
                    If p.X < found2XyMin.X AndAlso p.Y < found2XyMin.Y Then
                        found2XyMin.X = p.X
                        found2XyMin.Y = p.Y
                    End If
                Next
                If found1XyMin.X < found2XyMin.X AndAlso found1XyMin.Y < found2XyMin.Y Then
                    Return -1
                End If
                If found1XyMin.X > found2XyMin.X AndAlso found1XyMin.Y > found2XyMin.Y Then
                    Return 1
                End If
                If found1XyMin.Y < found2XyMin.Y Then
                    Return -1
                End If
                If found1XyMin.Y > found2XyMin.Y Then
                    Return 1
                End If
                Return 0
            End Function
        End Class

        Public Structure FoundBarCodes
            Public ReadOnly CodeText As String
            Public ReadOnly region As BarCodeRegion
            Public Sub New(text As String, reg As BarCodeRegion)
                CodeText = text
                region = reg
            End Sub
        End Structure
    End Class
    ' ExEnd:ReadAndSortBarcodesInSpecificOrder
End Namespace
