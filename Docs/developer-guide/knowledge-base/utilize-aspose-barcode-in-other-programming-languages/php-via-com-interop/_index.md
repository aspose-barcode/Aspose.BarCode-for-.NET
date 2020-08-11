---
title: PHP via COM Interop
type: docs
weight: 40
url: /net/php-via-com-interop/
---

## **Installation and Configuration**
PHP binaries for Windows are available from <http://www.php.net/>. In this section, we will only cover the basic configuration and installation steps for PHP configuration with IIS on Windows XP/2003 Server.

1. Download the binaries in zip format from <http://www.php.net/>.
1. Unzip at C:\php folder.
1. Set the above folder path in Environment Variables. Right click on My Computer, select Properties -> Advanced -> Environment

Variables -> System Variables. Edit the value of Path variable and append c:\php; at the end.

1. In C:\php folder, rename the php.ini-recommended to php.ini. Copy php.ini to c:\windows folder.
1. Open c:\windows\php.ini and comment the line doc_root=
1. Set the value of extension_dir to c:\php\ext# Create a new virtual directory in IIS and map it to some folder in your drive, where you will keep the source of php files.
1. In IIS, right click on the virtual directory, select properties -> Configuration -> Mappings. Press Add button. In Executable, browse for c:\php\php5isapi.dll. in Extension, enter .php.
1. Restart the IIS.

For testing of correct PHP configuration, create a new text file in the mapped folder of IIS virtual directory and name it as test.php. Enter the following lines in this file.
#### **PHP**
{{< highlight java >}}

 <?php

phpinfo();

?>

{{< /highlight >}}



Now, run the php file in browser. The URL should be similar as <http://localhost/virtualDirectory/test.php>. It should show your system and PHP version information. If there is any error, please visit [http://www.php.net](http://www.php.net/) for details about configuration instructions for your operating system. If you do not intend to use php.ini-recommended file as your configuration file, please visit <http://www.php.net/manual/en/ref.com.php> for adding COM support to PHP.
## **PHP Script to Generate BarCode**
The following PHP script displays an HTML form to enter the CodeText. Once you submit the form, an instance of BarCodeBuilder object will be created using COM interop and barcode will be generated in a folder of webserver.
#### **PHP**
{{< highlight java >}}

 {html}

<html>

<head>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<title>Generate BarCode in PHP using Aspose.BarCode for .NET</title>

</head>

<body>

<form name="form1" method="post" action="GenerateBarCode.php" ID="Form1">

    Please enter CodeText: <input name="txtCodeText" value="test-123" ID="Text1"/>

    <br />

    <input type="submit" value="Generate BarCode" ID="Submit1" NAME="Submit1"/>

</form>

<?php

// Error handler function

function customError($errno, $errstr)

{

	echo "<hr><b>Error:</b> [$errno] $errstr <br><hr>";

}

// Set error handler

set_error_handler("customError");//trigger error

// Request value of CodeText from the form

$strCodeText = $_POST['txtCodeText'];

// Check if codetext is empty

if ($strCodeText != "")

{

	// Create a new instance of BarCodeBuilder object using COM interop

	$barcodeBuilder = new COM("Aspose.BarCode.BarCodeBuilder");



	// Set the codetext, symbology type and save the barcode image in a folder of webserver

	$barcodeBuilder->CodeText = $strCodeText;

	$barcodeBuilder->SymbologyType = 15;

	$barcodeBuilder->Save("e:\\data\\aspose\\temp\\testphp.png");

}

?> </body>

</html>

{html}

{{< /highlight >}}



Please note that the above code sample uses constant value 4096 for Symbology type which is for Pdf417.
