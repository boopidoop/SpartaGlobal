echo "Comitting to Git"
git config --global user.name "boopidoop"
git config --global user.email "daniel.summerside@yahoo.com"
git add .
git commit -m "$Date : $Changelog"

git status >> log.txt

git reset