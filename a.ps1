echo "Comitting to Git"
git config --global user.name "boopidoop"
git config --global user.email "daniel.summerside@yahoo.com"
git add .

git status > status.txt
cat status

echo "-----------------------"
echo "Does this look correct?"
$Inputted = $false

while($Inputted -ne $true){
    $Confirmation = Read-Host -Prompt "[Y/N]"
    if ("y" -eq $Confirmation)
    {
        $Inputted = $true
        $Date = Get-Date
        $Changelog = Read-Host -Prompt "Please input  a changelog"
        git reset status.txt
        git commit -m "$Date : $Changelog"
        git status
        git push
    }
    elseif ("n" -eq $Confirmation)
    {
        $Inputted = $true
        git reset
    }
    else
    {
        echo "Please input Y/N"
        $Inputted = $false
    }
}

echo "Done, Committed to Git"