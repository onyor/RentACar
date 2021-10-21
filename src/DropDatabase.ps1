Write-Host ""
$Context = Read-Host "Enter DbContext Name [Default: 'RentACarContext']"

if ($Context.Trim() -eq "") {
    $Context = "RentACarContext"
}

Write-Host ""
Write-Host "Are you sure?"
Write-Host ""
$isOkey = Read-Host "Y/N"
Write-Host ""

if ($isOkey.ToLower() -eq "y") {
    Write-Host "Being deleted..."
    dotnet ef database drop -c $Context -p DataAccess -s WebAPI
}
elseif ($isOkey.ToLower() -eq "n") {
    Write-Host "OK. I don't deleted it!"
}
else {
    Write-Host "You entered an undefined expression! Try again..." -ForegroundColor DarkRed
}