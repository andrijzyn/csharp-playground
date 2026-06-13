#!/usr/bin/env bash

set -e

echo "Cleaning C#/.NET project..."

cat > .gitignore << 'EOF'
bin/
obj/
.vs/
[Bb]in/
[Oo]bj/

*.user
*.suo
*.cache
*.pdb
*.exe
*.dll

TestResults/
packages/
EOF

echo ".gitignore updated."

find . -type d \( -name bin -o -name obj -o -name .vs \) -prune -exec rm -rf {} +

echo "Local build folders removed."

git rm -r --cached . >/dev/null 2>&1 || true
git add .

echo "Tracked junk removed from Git index."
echo "Now commit the cleanup:"
echo 'git commit -m "Clean C# project for Git"'
