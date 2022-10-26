@echo off

echo "Creating release archive"
c:\msys64\usr\bin\env MSYSTEM=MINGW64 c:\msys64\usr\bin\bash -l -c "cd $(cygpath -w $USERPROFILE)/source/repos/kOS-KerbalEngineer; ./release.sh"
