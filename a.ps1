echo "Comitting to Git"
git config --global user.name "boopidoop"
git config --global user.email "daniel.summerside@yahoo.com"
git add .
git commit -m "test"

git status > log.txt
git log >> log.txt

git reset