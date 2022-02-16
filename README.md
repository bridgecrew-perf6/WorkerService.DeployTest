# WorkerService.DeployTest

You can run the Worker Service in various ways:

* Build and Debug/Run from within Visual Studio.
* Publish to an exe file and run it
* Run the sc utility (from Windows\System32) to create a new service

To publish the Worker Service as an exe file with dependencies, run the following dotnet command:

> dotnet publish -o C:\path\to\project\pubfolder

The -o parameter can be used to specify the path to a folder where you wish to generate the published files. It could be the path to your project folder, followed by a new subfolder name to hold your published files, e.g. pubfolder. Make a note of your EXE name, e.g. MyProjectName.exe but omit the pubfolder from your source control system.

To create a new service, run sc.exe from your System32 folder and pass in the name of the EXE file generated from the publish command.

> C:\Windows\System32\sc.exe create WorkerService.DeployTest binPath=C:\path\to\project\pubfolder\WorkerService.DeployTest.exe