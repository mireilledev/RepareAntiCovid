#!/bin/bash
inotifywait -e close_write,moved_to,create -m . |
while read -r directory events filename; do
  sh bundle.sh
done
