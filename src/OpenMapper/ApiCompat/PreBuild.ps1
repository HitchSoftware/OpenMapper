param([string]$version)
echo $version
$versionNumbers = $version.Split(".")
if($versionNumbers[1] -eq "0" -AND $versionNumbers[2] -eq "0")
{
    $oldVersion = $versionNumbers[0] - 1
}else{
    $oldVersion = $versionNumbers[0]
}
$oldVersion = $oldVersion.ToString() +".0.0"
echo $oldVersion
& ..\..\nuget install OpenMapper -Version $oldVersion -OutputDirectory ..\LastMajorVersionBinary
& copy ..\LastMajorVersionBinary\OpenMapper.$oldVersion\lib\net*.0\OpenMapper.dll ..\LastMajorVersionBinary
