﻿using Composite_Demo;

var rootFolder = new Folder("Root");
rootFolder.Add(new Folder("Folder1"));
rootFolder.Add(new Folder("Folder2"));

var complexFolder = new Folder("Folder3");
complexFolder.Add(new Folder("Folder4"));
complexFolder.Add(new Composite_Demo.File("NewFile.xml"));
complexFolder.Add(new Composite_Demo.File("NewFile2.xml"));

rootFolder.Add(complexFolder);

rootFolder.DisplayChildren(string.Empty);

Console.ReadKey();