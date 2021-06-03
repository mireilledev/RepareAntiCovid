#!/bin/bash
git add .
current="`date +'%Y-%m-%d %H:%M:%S'`"
msg="Updated: $current"
git commit -m "wip DEBUG and TESTING app $msg"
git push origin  master
