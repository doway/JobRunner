﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DOWAY's ConsoleJobRunner")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("DOWAY Studio")]
[assembly: AssemblyProduct("DOWAY Tools")]
[assembly: AssemblyCopyright("Copyright ©  2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e368654c-9f9e-4b7f-8b6b-40d3ee286c31")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
#if(DEBUG)
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("0.0.0.20130920")]
[assembly: AssemblyDescription("Debug build")]
#else
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.20130920")]
[assembly: AssemblyDescription("Release build")]
#endif
