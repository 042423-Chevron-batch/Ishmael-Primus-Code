#!/usr/bin/bash

continue="y"

while [ "$continue" == "y" ]
do
  echo "Enter your score?"
  read score

  if ((score >= 90 && score <= 100)); then
    echo "Letter Grade: A"
  elif ((score >= 80 && score <= 89)); then
    echo "Letter Grade: B"
  elif ((score >= 70 && score <= 79)); then
    echo "Letter Grade: C"
  elif ((score >= 60 && score <= 69)); then
    echo "Letter Grade: D"
  elif ((score >= 0 && score <= 59)); then
    echo "Letter Grade: F"
  else
    echo "Invalid score"
  fi

  read -p "Do you want to enter another score? (y/n)" continue
done

echo "See ya!"



