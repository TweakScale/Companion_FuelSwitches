using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("TweakScalerModuleFuelTanks")]
[assembly: AssemblyDescription("Implements TweakScale support for the ModuleFuelTanks PartModule")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(TweakScaleCompanion.FuelSwitches.LegalMamboJambo.Company)]
[assembly: AssemblyProduct(TweakScaleCompanion.FuelSwitches.LegalMamboJambo.Product)]
[assembly: AssemblyCopyright(TweakScaleCompanion.FuelSwitches.LegalMamboJambo.Copyright)]
[assembly: AssemblyTrademark(TweakScaleCompanion.FuelSwitches.LegalMamboJambo.Trademark)]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access destination type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("2f8662dc-114b-475b-b9a8-a069ea322e74")]

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
[assembly: AssemblyVersion(TweakScaleCompanion.FuelSwitches.Version.Number)]
[assembly: AssemblyFileVersion(TweakScaleCompanion.FuelSwitches.Version.Number)]
[assembly: KSPAssembly("TweakScaleCompanion_FuelSwitches", TweakScaleCompanion.FuelSwitches.Version.major, TweakScaleCompanion.FuelSwitches.Version.minor)]
[assembly: KSPAssemblyDependency("KSPe.Light.TweakScale", 2, 4)]
[assembly: KSPAssemblyDependency("Scale", 2, 5)]
