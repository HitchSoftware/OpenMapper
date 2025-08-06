#!/bin/bash
version=$1
echo $version
readarray -d . -t versionNumbers <<< $version
if [[ ${versionNumbers[1]} -eq "0" && ${versionNumbers[2]} -eq "0" ]]
then
    oldVersion=$(({versionNumbers[0]} - 1))
else
    oldVersion=${versionNumbers[0]}
fi
oldVersion="$oldVersion.0.0"
echo $oldVersion
rm -rf ../LastMajorVersionBinary
curl https://globalcdn.nuget.org/packages/OpenMapper.$oldVersion.nupkg --create-dirs -o ../LastMajorVersionBinary/OpenMapper.$oldVersion.nupkg
unzip -j ../LastMajorVersionBinary/OpenMapper.$oldVersion.nupkg lib/netstandard2.1/OpenMapper.dll -d ../LastMajorVersionBinary
