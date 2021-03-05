# Client-Server-App
 A small client-server proof of concept written in C# in Visual Studio 2019
 
 Depends on the Newtonsoft.Json library (.dll is included)
 
 Executables are found in the /executables folder
 To run the application:
  Run the ServerApp.exe in (/Executables/Server) first
  Then run the ClientApp.exe in (/Executables/Client) next.
 
 To change the storage configuration simply open the ServerApp.exe.config file and change the 'storage_type' app setting to either 'database' or 'file' 
 depending on which method you want to use.

 Database is a MSSQLSERVER hosted on localhost of your machine the database it accesses is simply the 'master' database. So install a fresh version of 
 Microsoft SQL Server Developer to make sure it doesn't conflict with any database testing you're doing currently.
