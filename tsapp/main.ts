import { execSync } from 'child_process';

let message: string = execSync('dotnet ./../netapp/bin/Debug/net7.0/netapp.dll').toString();
console.log(message);