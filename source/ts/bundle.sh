#!/bin/sh
deno bundle repare.ts ../compiled/repare.js --config tsconfig.json
#minifier ../compiled/repare.js ../compiled/repare_mini.js
cp ../compiled/repare.js ../../js/


