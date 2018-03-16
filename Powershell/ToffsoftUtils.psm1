<# 
 .Synopsis
  Parses INI or INF files into a Hashtable

 .Description
  Parses INI or INF files into a Hashtable

 .Parameter FullPath
  the fully qualified path to the ini or inf file

 .Example
   Get-IniInfContent -FullPath "path:\to\the\ini\or\inf\file.inf"
#>
function Get-IniInfContent {
    param (
        [parameter(mandatory=$true)]
        [string]
        $FilePath
    )

    Write-Host "Processing file: $FilePath"

    $iniinf = @{}  
    switch -regex -file $FilePath  
    {  
        "^\[(.+)\]$" # Section  
        {  
            $section = $matches[1]  
            $iniinf[$section] = @{}  
            $CommentCount = 0  
        }  
        "^(;.*)$" # Comment  
        {  
            if (!($section))  
            {  
                $section = "No-Section"  
                $iniinf[$section] = @{}  
            }  
            $value = $matches[1]  
            $CommentCount = $CommentCount + 1  
            $name = "Comment" + $CommentCount  
            $iniinf[$section][$name] = $value  
        }   
        "(.+?)\s*=\s*(.*)" # Key  
        {  
            if (!($section))  
            {  
                $section = "No-Section"  
                $iniinf[$section] = @{}  
            }  
            $name,$value = $matches[1..2]  
            $iniinf[$section][$name] = $value  
        }  
    }

    Write-Host "Finished Processing file: $FilePath"
    return $iniinf
}