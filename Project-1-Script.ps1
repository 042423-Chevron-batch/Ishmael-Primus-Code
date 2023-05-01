# Project_1 Script that prompts the user to enter a file path, reads the contents of the file, and displays a message indicating whether the file contains text or not in a table:

# Prompt the user to enter a directory path
$dirPath = Read-Host "Enter a directory path"

# Get all files in the directory
$files = Get-ChildItem -Path $dirPath -Recurse -File

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
