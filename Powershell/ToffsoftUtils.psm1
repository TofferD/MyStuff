<# 
 .Synopsis
  converts a generic powershell object into a hashtable

 .Description
  converts a generic powershell object into a hashtable

 .Parameter PSObject
  a generic powershell object

 .Example
   Convert-PSObjToHash -PSObject $somePSObject
#>
function Convert-PSObjToHash
{
    param (
        [Parameter(Mandatory = $true)]
        $PSObject
    )
    
    $convertedHash = @{}

    $PSObject.PSObject.Properties | ForEach-Object {
        if ($_.Value.GetType().Name -eq "String")
        {
            $convertedHash.Add($_.Name, $_.Value)
        }
        else
        {
            $convertedSubPSObj = ConvertPSObjToHash $_.Value
            $convertedHash.Add($_.Name, $convertedSubPSObj)
        }
    }

    return $convertedHash
}

<# 
 .Synopsis
  Generates a random string of N length

 .Description
  Generates a random string of N length using only the following characters:
  ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789

 .Parameter StringLength
  the length of the random string to create

 .Example
   Get-RandomString -StringLength 7
#>
function Get-RandomString {
    param (
        # Parameter help description
        [Parameter(Mandatory=$true)]
        [int]
        $StringLength
    )
}

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
        [Parameter(Mandatory=$true)]
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