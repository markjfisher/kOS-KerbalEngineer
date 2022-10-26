# kOS-KerbalEngineer

[Kerbal Engineer](https://github.com/jrbudda/KerbalEngineer) functionality in kOS.

See [Release Readme](GameData/kOS-KerbalEngineer/README.md) for mod usage information.

## Building

TODO:
The module is available in CKAN, but if you wish to check out and build it yourself, the following will help.

### Visual Studio 2022 in Windows

#### Copy required mods to a folder on your machine
Unpack the following mods as normal from installation zips, or copy them from KSP's mods folder.

- KerbalEngineer
- kOS

These need to go somewhere on your machine, e.g. "C:\your\path\to\dev\mods\"

#### Create symlinks to KSP Data and Mod data.

From the root of the project, run the following commands to create symlinks.

You will need to adjust the paths to your own environment.

```
mklink /j Source\KSP_Data "C:\your\path\to\Steam\steamapps\common\Kerbal Space Program\KSP_x64_Data"
mklink /j Source\KSP_GameData "C:\your\path\to\dev\mods\"
```

Warning: If you link this to your main KSP mods folder, you may get compilation issues, as some mods
have Assembly files included in their distribution, that will break the build of this module.
That took me a while to find :sad-panda:.

Now the base game libraries and mods are available, run Visual Studio 2022, and run a realease build.

You will then need to copy the release in [GameData/kOS-KerbalEngineer](GameData/kOS-KerbalEngineer) to your Mods folder, or symlink it.

e.g.

```
mklink /j kOS-KerbalEngineer "C:\path\to\source\repos\kOS-KerbalEngineer\GameData\kOS-KerbalEngineer"
```