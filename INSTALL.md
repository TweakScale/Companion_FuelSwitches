# TweakScale Companion :: FuelSwitches

Adds (up to date) TweakScale /L support for FuelSwitches, allowing parts using them to be scaled if patches are applied.


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/TweakScaleCompanion/FuelSwitches`
* Extract the package's `GameData/` folder into your KSP's as follows:
	+ `<PACKAGE>/GameData/TweakScaleCompanion/FuelSwitches` --> `<KSP_ROOT>/GameData/TweakScaleCompanion`
		- Overwrite any preexisting file.

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[Deprecating]
			...
		[Docs]
			...
		[TweakScale]
			[Plugins]
				KSPe.Light.TweakScale.dll
				Scale.dll
			[patches]
				...
			CHANGE_LOG.md
			LICENSE
			NOTICE
			README.md
			TweakScale.version
		999_Scale_Redist.dll
		ModuleManager.dll
		...
		[TweakScaleCompanion]
			[...]
			[FuelSwitches]
				CHANGE_LOG.md
				LICENSE*
				NOTICE
				README.md
				[patches]
					...
			[...]
	KSP.log
	PartDatabase.cfg
	...
```


### Dependencies

* TweakScale /L 2.5.0.50 or later
	+ **NOT** included
* Module Manager 3.1.3 or later
	+ **NOT** included
