# inoPBI

The applications generates a documentation of a Power BI Project (*.pbip) with all measures and PowerQuery definitions as PDF file.

Furthermore the application is able to replace PowerQuery parameters and shows where a measure is used within defined measures and reports.

inoPBI defines projects to keep different settings for each project.

Currently the GUI is available in English and German.

## Usage

How to use the application is in a [separate tutorial](/sources_documentation/HowToUse.md).


## Installation

Download the latest release from [https://github.com/INOPIAE/inoPBI/releases/](https://github.com/INOPIAE/inoPBI/releases/).

Unzip the zip file and use `inoPBI.exe` to start the application inoPBI.

![Screenshot Start I](/sources_documentation/first_use_1.png)

During the first start you are prompted for an untrusted issuer. This is due to the fact that the certificate is not issued by a CA located in the general trust stores.

Use `further indformation` to continue.

![Screenshot Start II](/sources_documentation/first_use_2.png)

Use `Continue` finish the start process.

## Dependencies

inoPBI uses [Markdown2Pdf](https://github.com/Flayms/Markdown2Pdf) to generate pdf files.