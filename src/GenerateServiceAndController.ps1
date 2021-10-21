$nsAbstractService = "Application.Interfaces.Data"
$nsConcreteService = "Infrastructure.Data.Services"
$nsController = "WebAPI.Controllers"
$nsModel = "Domain.Entities"
$pathController = "./WebAPI/Controllers"
$pathAbstractService = "./Application/Interfaces/Data"
$pathConcreteService = "./Infrastructure/Data/Services"

$className = Read-Host "Please Enter Class Name [Required]"
$classNameLower = $className.ToLower()
if ($className.Trim() -eq "") {
    Write-Host ""
    Write-Host "Class Name Is Required!" -ForegroundColor DarkRed
    Exit
}

Write-Host ""
$Context = Read-Host "Enter DbContext Name [Default: 'AktifCloudDbContext']"

if ($Context.Trim() -eq "") {
    $Context = "AktifCloudDbContext"
}
Write-Host ""

<# Required in IMS Project
$namespace = Read-Host "Please Enter Namespace [Optional]"
if ($namespace.Trim() -ne "")
{
  $nsService = "$($nsService).$($namespace)"
  $nsModel = "$($nsModel).$($namespace)"
  $pathService = "./$($pathService)/$($namespace)"
}
#>

# Create Controllers directory if not exist
if (!(Test-Path $pathController)) {
    New-Item -ItemType Directory -Force -Path $pathController
}

# Create Concrete Services directory if not exist
if (!(Test-Path $pathConcreteService)) {
    New-Item -ItemType Directory -Force -Path $pathConcreteService
}

# Create Abstract Services directory if not exist
if (!(Test-Path $pathAbstractService)) {
    New-Item -ItemType Directory -Force -Path $pathAbstractService
}

#region Controller Code
$controllerFileText = @"
    using $($nsAbstractService);
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    namespace $($nsController)
    {
        [Route("api/[controller]")]
        [ApiController]
        [AllowAnonymous]
        public class $($className)sController : ControllerBase
        {
            private readonly IMapper _mapper;
            private readonly I$($className)Service _$($classNameLower)Service;

            public $($className)sController(
                IMapper mapper,
                I$($className)Service $($classNameLower)Service)
            {
                _mapper = mapper;
                _$($classNameLower)Service = $($classNameLower)Service;
            }

        }
    }
"@

echo $controllerFileText >> "$($pathController)/$($className)sController.cs"

#endregion

#region IService Code
$iServiceFileText = @"
    using $($nsModel);
    using Domain.Interfaces;

    namespace $($nsAbstractService)
    {
        public interface I$($className)Service : IBaseService<$($className)>
        {

        }
    }
"@

echo $iServiceFileText >> "$($pathAbstractService)/I$($className)Service.cs"

#endregion

#region Service Code
$serviceFileText = @"
    using $($nsAbstractService);
    using $($nsModel);

    namespace $($nsConcreteService)
    {
        public class $($className)Service : EfService<$($className)>, I$($className)Service
        {
            public $($className)Service($($Context) dbContext) : base(dbContext)
            {
                
            }
        }
    }
"@

echo $serviceFileText >> "$($pathConcreteService)/$($className)Service.cs"

#endregion