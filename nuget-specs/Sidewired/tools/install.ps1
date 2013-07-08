param($installPath, $toolsPath, $package, $project) 
$path = [System.IO.Path] 
$readmefile = $path::Combine($installPath, "content\README.txt") 
$DTE.ItemOperations.OpenFile($readmefile) 