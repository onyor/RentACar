Write-Host ""

$Name = Read-Host "Please Enter Migration Name [Required]"

if ($Name.Trim() -eq "") {
    Write-Host ""
    Write-Host "Migration Name Is Required!"
    Exit
}

Write-Host ""

$Context = Read-Host "Enter DbContext Name [Default: 'RentACarDBContext']"
if ($Context.Trim() -eq "") {
    $Context = "RentACarDBContext"
}

Write-Host ""
Write-Host "Creating Migration..."
Write-Host ""

dotnet ef migrations add $Name -c $Context -p DataAccess -s WebAPI -o Concrete/Migrations

<#  Projec -> IMS 
    dotnet ef migrations add $Name -s IMS.Service.Api -c $Context -p IMS.Data.Core
#>