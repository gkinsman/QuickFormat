try {
    Push-Location ./QuickFormat.App
    dotnet clean
    dotnet publish -o ../out -r win-x64 -c Release /p:PublishSingleFile=true
} finally {
    Pop-Location
}