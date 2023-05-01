# Project_1 Script that prompts the user to enter a file path, reads the contents of the file, and displays a message indicating whether the file contains text or not:

# Prompt the user to enter a file path
$filePath = Read-Host "Enter a file path"

# Read the contents of the file
$contents = Get-Content $filePath

# Check if the file contains text and display a message
if ($contents.Length -gt 0) {
    Write-Host "The file $($filePath) contains text.`nContents:`n$contents`n"
} else {
    Write-Host "The file $($filePath) is empty."
}
