After searching the web I couln't find a *good* example of a font chooser for Windows Phone 7,
so I put this together, this will work with either 7.0 NoDo or 7.1 Mango!

Ive included three custom fonts to show how that works too.

One is embedded with Expression Blend using the Font Manager:

    [To embed a font using the Font Manager] (http://msdn.microsoft.com/en-us/library/cc294629.aspx)

One included as Content:

    Drag & Drop into Visual Studio -> Properties -> Content & Copy if newer

Also one as a Resource:

    Drag & Drop into Visual Studio -> Properties -> Resource & Don't Copy


This project contains a reference to [The Silverlight Toolkit] (http://silverlight.codeplex.com/)
You will need this if you want to implement it in your own project.

Or it's easiest to use [NuGet](http://visualstudiogallery.msdn.microsoft.com/27077b70-9dad-4c64-adcf-c7cf6bc9970c) to install it