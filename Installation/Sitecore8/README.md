Sitecore 8 Installation
========

## Manual installation notes
All steps are manual in this guide, no Sitecore Instance Manager (SIM) or MSI installation

###  PREREQUISITE
Windows, IIS server, Mssql, Mongodb, Visual Studio

### DOWNLOAD
* Have a developer license.xml file
* login and download 'ZIP archive of the Sitecore site root' from http://dev.sitecore.net
* Unblock the zip file and extract the content

### DB
* Move the Sitecore DB files to a database folder 
* Ensure MSSQLSERVER has security rights for the DB files (right click, properties, add user permission) 
* Attach the DB's to MSSQL
* Add a db sitecore user to have ownership of the DB's
* Download and Install mongodb
* Start mongodb from command line
* `cd "C:\Program Files\MongoDB 2.6 Standard\bin"`
* `mongod -dbpath "C:\databases\sitecore8"`
* Install robomongo (optional)
* start robomongo and connect to localhost (optional)
    
### WEB DEPLOY
* Copy web files to folder
* Rename LiveMode.config.example to LiveMode.config
* Update the connection string for ConnectionStrings.config
* Copy Data folder to inside web folder and rename to folder to data
* Place the license.xml file inside data folder
* Create IIS site for Sitecore8 with binding `sitecore8.local`
* Add to host file `127.0.0.1 sitecore8.local`

### WEB DEVELOPMENT
* Install Sitecore rocks
* Connect Sitecore rocks from Visual studio to the DB
* Create a new empty Web project with .Net Framework 4.5+
* Copy from deploy folder to package folder
*     Sitecore.Mvc
*     Sitecore.Kernell
* Reference the files dlls and select copy Locals false
* install from package manager console
*     `Install-Package Microsoft.AspNet.Razor -Version 3.0.0`
*     `Install-Package Microsoft.AspNet.Webpages -Version 3.0.0`
*     `Install-Package Microsoft.AspNet.Mvc -Version 5.1.0.0`
* Copy web.config from web deploy folder to solution folder
* Delete global asax files
* Create folders Controllers, Models, Views
* Build and Publish project to `sitecore8.local IIS instance`
