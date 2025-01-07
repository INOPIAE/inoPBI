# How to use inoPBI

During the start of the application it is checked if a project is defined. If not the Select Project dialog is opened.

# Menue
## File

## Power BI Tools

![Screenshot Create pdf file](/sources_documentation/powerbitools.png)

### Select Project

![Screenshot project](/sources_documentation/projects.png)

The application needs a project definition to store the different values fro  the forms.

#### Select Project
Selects the highligthed project.

#### New project
Here a new project is defined

#### Rename project
Rename the highligthed project

### Edit Footer/Header

![Screenshot Edit Footer/Header](/sources_documentation/edithtml.png)

### Documentation

![Screenshot Create pdf file](/sources_documentation/create_pdf.png)

#### Create documentation 

To create the documentation file give the path to the Power BI project file and define the location where the documentation file should be stored.

Use `Create Documenation` to generate the documentation file.

#### Create PDF 

Documentation file defines the path to the documentation markdown file (see above).

Header HTML file defines the path to an html containing formatting information for the pdf file header. Is needed if the Document title is used.

Footer HTML file defines the path to an html containing formatting information for the pdf file heafooter. Is needed if the page numbering should be given.

Example files can be found in [/inoPBI/inoPBI/pdfsettings](/inoPBI/inoPBI/pdfsettings).

Target file defines the path to the pdf file.

Document tile defines the text for the document header. Header HTML file is needed to display the text in the header.

Show PDF file defines if the pdf file is opend after the generation of the file.

`Create PDF` generated the documentation pdf file.

### Replacement Parameters - Replace PowerQuery parameters and generate documentation markdown file

![Screenshot Replace TDML](/sources_documentation/replace_tmdl.png)

#### Replace PowerQuery parameters

Power BI file defines the Power BI project file (*.pbip).

File with replacements defines the path to the file with the replacement information.

Target folder defines the folder where the dashboard with replacements is stored

Customer extension defines a file extention to identify the orginal and replace expression files

Use `Replace` to start the replacement. This will create a copy of the dashboard with the replaced PowerQuery paramters and a zip file of the dashboard folder.


#### Generation of documentation markdown file

Select Original and define path and name of markdown file. 

Use `Create documentation` to create markdown file

`Create PDF` opens dialog for pdf generation

## Tools

![Screenshot Settings](/sources_documentation/settings.png)

## Windows

## Help
