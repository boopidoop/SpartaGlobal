echo "Comitting to Git"
git config --global user.name "boopidoop"
git config --global user.email "daniel.summerside@yahoo.com"
git add .
git commit -m "$Date : $Changelog"



$Changelog = Read-Host -Prompt "Input Changelog Text"
$Date = Get-Date


git status
git push