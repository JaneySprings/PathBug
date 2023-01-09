dotnet build ./netapp/netapp.csproj
cd ./tsapp
npm install
tsc ./main.ts
node ./main.js