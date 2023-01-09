"use strict";
exports.__esModule = true;
var child_process_1 = require("child_process");
var message = (0, child_process_1.execSync)('dotnet ./../netapp/bin/Debug/net7.0/netapp.dll').toString();
console.log(message);
