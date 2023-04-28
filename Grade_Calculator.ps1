$continue = 'y'
while ($continue -eq 'y' ) {
    $score = Read-Host "Enter your score"
    Write-Host "The entered score is " $score

    if ($score -ge 90 -and $score -le 100)
    {
        Write-Output "Letter Grade: A"
    }
    elseif ($score -ge 80 -and $score -le 89)
    {
        Write-Output "Letter Grade: B"
    }
    elseif ($score -ge 70 -and $score -le  79)
    {
        Write-Output "Letter Grade: C" 
    }
    elseif ($score -ge 60 -and $score -le 69)
    {
        Write-Output "Letter Grade: D"
    }
    elseif ($score -ge 0 -and $score -le 59)
    {
        Write-Output "Letter Grade: F"
    }
    else {
         Write-Output "Invalid score"
    }
    Write-Host "Do you want to enter another score? (y/n)"
    $continue = Read-Host
}
Write-Output "See ya!"