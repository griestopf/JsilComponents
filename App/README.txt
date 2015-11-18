Test to JSIL cross compile a simple application (App) together with a self-written, portable library (DaLibrary).

To successfully compile App make sure you have the latest JSIL version intalled (https://github.com/sq/JSIL).
Next You need to tell the App project where to find JSIL.

To do so, edit the App project's properties (In Visual Studio, right-click on the App project)
go to the "Build Events" tab and alter the first line of the "Post-build event command line":
SET JSILROOT=<YOUR-JSIL-ROOT-DIRECTORY>

Replace <YOUR-JSIL-ROOT-DIRECTORY> to the place on your harddisk where your JSIL clone resides.

At the moment all cross-compilation is done in App. JSIL analyzes App.exe and finds that it references
DaLibrary.dll. So JSIL then also xcompiles DaLIbrary. The goal is to have JSIL compile the solution in 
two different parts - each assembly as a part of its own.