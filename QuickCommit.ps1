echo "Comitting to Git"
git --config user.name "boopidoop"
git --config user.email "daniel.summerside@yahoo.com"

$Changelog = Read-Host -Prompt "Input Changelog Text"
$Date = Get-Date

git add .
git commit -m "$Date : $Changelog"
git status
git push