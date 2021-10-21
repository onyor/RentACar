Write-Host ""
$Context = Read-Host "Enter DbContext Name [Default: 'RentACarContext']"
Write-Host ""
if ($Context.Trim() -eq "") {
    $Context = "RentACarContext"
}
Write-Host ""
Write-Host "Removing last Migration..."
Write-Host ""
dotnet ef migrations remove -c $Context -p DataAccess -s WebAPI

<#  Projec -> IMS
    dotnet ef migrations remove -s IMS.Service.Api -c $Context -p IMS.Data.Core
#>