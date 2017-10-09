To change data source from local json to web api.

The default data source is from local json files. 
This can be changed by changing lines 9 and 10 
From 
    <!--<script src="scripts/FromWebApi.js"></script>-->
    <script src="scripts/FromLocalJsonFile.js"></script>
To
<script src="scripts/FromWebApi.js"></script
<!--<script src="scripts/FromLocalJsonFile.js"></script>>-->

in {root}\HotelsProject\Hotels.Web\index.html

This project uses SQLExpress2014. Change connection string in {root}\HotelsProject\Hotels.Core\App.config line 18.

    <add name="hotels" connectionString="{YOUR-CONNECTION-STRING};App=EntityFramework" providerName="System.Data.SqlClient" />

Run Update-Database from package manager console.
This should create a database and necessary tables.
Change connection string in {root}\HotelsProject\Hotels.Api\Web.config line 79 with the new connection string.

Host in IIS

Create two web sites in IIS. One for web api and one for angular. 

Note the hostname for web api project and replace the hostname with the current hostname in {root}\HotelsProject\Hotels.Web\scripts\FromWebApi.js file, line 3 as 
http://{HOSTNAME}/api/Hotels/

Additional notes.
This project creates a database named hotels by default. Make sure that the server does not contain a database named hotels before running Update-Database from package manager console.

This solution does not contain a test project.

The angular project uses content delivery networks for angular and needs internet connectivity on IIS machine. To change this behavior, change line 6 and 7 to 

    <script src="scripts/angular.min.js"></script>
    <script src="scripts/angular-route.js"></script>
 
