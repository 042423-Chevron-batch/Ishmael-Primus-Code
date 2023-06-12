# Project_1 Script that prompts the user to enter a file path, reads the contents of the file, and displays a message indicating whether the file contains text or not in a table:

while ($true) {
    $dir = Read-Host "Enter a directory path"
    if (Test-Path $dir -PathType Container) {
        # Code to execute if directory exists goes here
        Write-Host "Directory exists"
        break
    }
    else {
        # Code to execute if directory does not exist goes here
        Write-Host "Directory does not exist"
    }
}

# Get all files in the directory
$files = Get-ChildItem -Path $dir -Recurse -File

# Create an array to store the table data
$tableData = @()

# Loop through each file and add a row to the table indicating if it contains text
foreach ($file in $files) {
    $contents = Get-Content $file.FullName
    $hasText = if ($contents.Length -gt 0) { "Yes" } else { "No" }
    $row = New-Object PSObject -Property @{ 
        "File Name" = $file.Name
        "Has Text" = $hasText 
    }
    $tableData += $row
}

# Display the table
$tableData | Format-Table "File Name", "Has Text"
