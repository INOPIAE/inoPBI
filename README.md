# inoPBI

The applications generates a documentation of a Power BI Project (*.pbip) with all measures and PowerQuery definitions as PDF file.

Furthermore the application is able to replace PowerQuery parameters and shows where a measure is used within defined measures and reports.

inoPBI defines projects to keep different settings for each project.

Currently the GUI is available in English and German.

## Usage

### Replace PowerQuery parameters and generate documentation markdown file

![Screenshot Replace TDML](/sources_documentation/replace_tmdl.png)

#### Replace PowerQuery parameters

Orginal defines the folder SemanticModel or Dataset from the dashboard folder.

File with replacements defines the path to the file with the replacement information.

Target folder defines the folder where the dashboard with replacements is stored

Customer extension defines a file extention to identify the orginal and replace expression files

Use 'Replace' to start the replacement. This will create a copy of the dashboard with the replaced PowerQuery paramters and a zip file of the dashboard folder.


#### Generation of documentation markdown file

Select Original and define path and name of markdown file. 

Use 'Create documentation' to create markdown file

'Create PDF' opens dialog for pdf generation

### Generate PDF file

![Screenshot Create pdf file](/sources_documentation/create_pdf.png)

Documentation file defines the path to the documentation markdown file (see above).

Header HTML file defines the path to an html containing formatting information for the pdf file header. Is needed if the Document title is used.

Footer HTML file defines the path to an html containing formatting information for the pdf file heafooter. Is needed if the page numbering should be given.

Example files can be found in /inoPBI/inoPBI/pdfsettings.

Target file defines the path to the pdf file.

Document tile defines the text for the document header. Header HTML file is needed to display the text in the header.

Show PDF file defines if the pdf file is opend after the generation of the file.

'Create PDF' generated the documentation pdf file.

## Installation

Currently there is no installation package available so download the repository and open the solution in Visual Studio 2022 to build an exe file.

(Working on the installation package)


## Dependencies

inoPBI uses [Markdown2Pdf](https://github.com/Flayms/Markdown2Pdf) to generate pdf files.