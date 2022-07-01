echo "Comitting to Git"
git config --global user.name "boopidoop"
git config --global user.email "daniel.summerside@yahoo.com"
git add .

$Changelog = Read-Host -Prompt "Input Changelog Text"
$Date = Get-Date
echo git status
git commit -m "$Date : $Changelog"


git status
git push