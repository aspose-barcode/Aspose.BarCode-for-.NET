---
title: How to use Aspose.BarCode in Client Report Definition (.rdlc) Files
type: docs
weight: 20
url: /net/how-to-use-aspose-barcode-in-client-report-definition-rdlc-files/
---

In this article, we will create a client report definition file (RDCL) and integrate our Aspose.BarCode component with it.

1. Create a new project in Visual Studio 2005.
1. Select **Windows Application** as the project type.
1. Add a new DataSet to the project by right-clicking the project from the Solution Explorer and selecting Add, then New Item.
1. Select **DataSet** from the templates box.
1. Add a new TableAdapter to the dataset by right-clicking on the dataset's design view, selecting **Add** and then **TableAdapter**.
1. Create a new database connection or select a connection from the dropdown.

If creating a new connection, please give the database server name and authentication information and select “AdventureWorks” as your database. Make sure that if you click **Test Connection**, you get a “Test Connection Succeeded” message. On the Choose a Command Type screen, choose **Use SQL Statements** and click **Next**. Type the following query in **Enter a SQL Statement**:
#### **C#**
{{< gist "aspose-barcode" "2224aabcdb4d2a259b10" "Examples-CSharp-GenerateBarCodecolumn-GenerateBarCodecolumn.cs" >}}



Run the project. The 2 BarCode column should show barcode images on the report.
