$propsJoined = $args[0]
$typesJoined = $args[1]
$requiredJoined = $args[2]
$keysJoined = $args[3]
$SolutionFolder = $args[4]
$WebApiName = $args[5]
$ProjectName = $args[6]
$SolutionInstallPath = $args[7]
# $HostName = $args[10]
# $ApiPortNo = $args[11]


cd $SolutionInstallPath\$SolutionFolder\$WebApiName

function splitter { return $propsJoined.split('-') }
$props = splitter

function splitter { return $typesJoined.split('-') }
$types = splitter

function splitter { return $requiredJoined.split('-') }
$required = splitter

function splitter { return $keysJoined.split('-') }
$key = splitter
for ( $i = 0; $i -lt $key.count; $i++ ) {
    if ($key -eq "//") {
        $key[$i] = " "
    }
}

$propsConcat = @()

mkdir Models
cd Models

# Creating Model
for ($i = 0; $i -lt $props.Length; $i++) {
    $propsConcat += "$($key[$i])
        $($required[$i])
        public $($types[$i]) $($props[$i]) { get; set; }"
}
$propsJoined = $propsConcat -join "`n        "

New-Item -Path . -Name "$ProjectName.cs" -ItemType "file" -Value "using System.ComponentModel.DataAnnotations;

namespace $($ProjectName)Service.Models
{
    public class $ProjectName
    {
        $propsJoined
    } 
}"
cd..

# Creating Dtos
mkdir Dtos
cd Dtos
$dtoRead = @()
for ($i = 0; $i -lt $props.Length; $i++) {
    $dtoRead += "public $($types[$i]) $($props[$i]) { get; set; }"
}
$dtoReadJoined = $dtoRead -join "`n        "

New-Item -Path . -Name "$($ProjectName)ReadDto.cs" -ItemType "file" -Value "namespace $($ProjectName)Service.Dtos
{
    public class $($ProjectName)ReadDto
    {
        $dtoReadJoined
    }
}"


$dtoCreate = @()
for ($i = 1; $i -lt $props.Length; $i++) {
    $dtoCreate += "$($key[$i])
        $($required[$i])
        public $($types[$i]) $($props[$i]) { get; set; }"
}
$dtoCreateJoined = $dtoCreate -join "`n        "

New-Item -Path . -Name "$($ProjectName)CreateDto.cs" -ItemType "file" -Value "using System.ComponentModel.DataAnnotations;

namespace $($ProjectName)Service.Dtos
{
    public class $($ProjectName)CreateDto
    {
        $dtoCreateJoined
    }
}"
cd..

# Create Profile
mkdir Profiles
cd Profiles
New-Item -Path . -Name "$($ProjectName)Profile.cs" -ItemType "file" -Value "using AutoMapper;
using $($ProjectName)Service.Dtos;
using $($ProjectName)Service.Models;

namespace $($ProjectName)Service.Profiles
{
    public class $($ProjectName)sProfile : Profile
    {
        public $($ProjectName)sProfile()
        {
            //Sources -> Target
            CreateMap<$($ProjectName), $($ProjectName)ReadDto>();
            CreateMap<$($ProjectName)CreateDto, $($ProjectName)>();
        }
    }
}"
cd..



# Creating PrepDb / Database initialization
mkdir Data
cd Data
# TODO seeded data should be corrected
New-Item -Path . -Name "PrepDb.cs" -ItemType "file" -Value "using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using $($ProjectName)Service.Models;

namespace $($ProjectName)Service.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.$($ProjectName)s.Any())
            {
                Console.WriteLine(`"--> Seeding data...`");

                //Example test data                                    
                context.$($ProjectName)s.AddRange(
                    //new $($ProjectName)() { FirstName = `"Anders`", LastName = `"Jensen`", PhoneNo = `"22461458`", Email = `"Free@andersen.com`" },
                    //new $($ProjectName)() { FirstName = `"Henry`", LastName = `"Davidsen`", PhoneNo = `"88462433`", Email = `"hen@block.com`" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine(`"--> We already have data`");
            }
        }
    }
}" 

# Creating IRepo 
New-Item -Path . -Name "I$($ProjectName)Repo.cs" -ItemType "file" -Value "using System.Collections.Generic;
using $($ProjectName)Service.Models;

namespace $($ProjectName)Service.Data
{
    public interface I$($ProjectName)Repo
    {
        bool SaveChanges();

        IEnumerable<$($ProjectName)> GetAll$($ProjectName)s();
        $($ProjectName) Get$($ProjectName)ById(int id);
        void Create$($ProjectName)($($ProjectName) plat);
    }
}"

# Creating Repo 
New-Item -Path . -Name "$($ProjectName)Repo.cs" -ItemType "file" -Value "using System;
using System.Collections.Generic;
using System.Linq;
using $($ProjectName)Service.Models;

namespace $($ProjectName)Service.Data
{
    public class $($ProjectName)Repo : I$($ProjectName)Repo
    {

        private readonly AppDbContext _context;

        public $($ProjectName)Repo(AppDbContext context)
        {
            _context = context;
        }

        public void Create$($ProjectName)($($ProjectName) plat)
        {

            if (plat == null)
            {
                throw new ArgumentNullException(nameof(plat));
            }

            _context.$($ProjectName)s.Add(plat);
        }

        public IEnumerable<$($ProjectName)> GetAll$($ProjectName)s()
        {
            return _context.$($ProjectName)s.ToList();
        }

        public $($ProjectName) Get$($ProjectName)ById(int id)
        {
            return _context.$($ProjectName)s.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}"

# Creating AppDbContext 
New-Item -Path . -Name "AppDbContext.cs" -ItemType "file" -Value "using Microsoft.EntityFrameworkCore;
using $($ProjectName)Service.Models;

namespace $($ProjectName)Service.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<$($ProjectName)> $($ProjectName)s { get; set; }
    }
}"
cd..

# Creating Controller 
cd Controllers
del WeatherForecastController.cs

New-Item -Path . -Name "$($ProjectName)Controller.cs" -ItemType "file" -Value "using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using $($ProjectName)Service.Data;
using $($ProjectName)Service.Dtos;
using $($ProjectName)Service.Models;
using $($ProjectName)Service.SyncDataServices.Http;

namespace $($ProjectName)Service.Controllers
{
    [Route(`"api/[controller]`")]
    [ApiController]
    public class $($ProjectName)sController : ControllerBase
    {
        private readonly I$($ProjectName)Repo _repository;
        private readonly IMapper _mapper;
        private readonly ICommandDataClient _commandDataClient;

        public $($ProjectName)sController(I$($ProjectName)Repo repository, IMapper mapper, ICommandDataClient commandDataClient)
        {
            _repository = repository;
            _mapper = mapper;
            _commandDataClient = commandDataClient;
        }
        [HttpGet]
        public ActionResult<IEnumerable<$($ProjectName)ReadDto>> Get$($ProjectName)s()
        {
            Console.WriteLine(`"--> Getting $($ProjectName)s....`");

            var $($ProjectName)Item = _repository.GetAll$($ProjectName)s();

            return Ok(_mapper.Map<IEnumerable<$($ProjectName)ReadDto>>($($ProjectName)Item));
        }

        [HttpGet(`"{id}`", Name = `"Get$($ProjectName)ById`")]
        public ActionResult<$($ProjectName)ReadDto> Get$($ProjectName)ById(int id)
        {
            var $($ProjectName)Item = _repository.Get$($ProjectName)ById(id);
            if ($($ProjectName)Item != null)
            {
                return Ok(_mapper.Map<$($ProjectName)ReadDto>($($ProjectName)Item));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<$($ProjectName)ReadDto>> Create$($ProjectName)($($ProjectName)CreateDto $($ProjectName)CreateDto)
        {
            var $($ProjectName)Model = _mapper.Map<$($ProjectName)>($($ProjectName)CreateDto);
            _repository.Create$($ProjectName)($($ProjectName)Model);
            _repository.SaveChanges();

            var $($ProjectName)ReadDto = _mapper.Map<$($ProjectName)ReadDto>($($ProjectName)Model);

            try
            {
                await _commandDataClient.Send$($ProjectName)ToCommand($($ProjectName)ReadDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($`"--> Could not send synchronously: {ex.Message}`");
            }

            return CreatedAtRoute(nameof(Get$($ProjectName)ById), new { Id = $($ProjectName)ReadDto.Id }, $($ProjectName)ReadDto);
        }
    }
}"
cd..
    
# Creating SyncDataService
mkdir SyncDataServices
cd SyncDataServices
New-Item -Path . -Name "HttpCommandDataClient.cs" -ItemType "file" -Value "using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using $($ProjectName)Service.Dtos;

namespace $($ProjectName)Service.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        //This is an example that has to be changed
        public async Task Send$($ProjectName)ToCommand($($ProjectName)ReadDto plat)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                `"application/json`");

            var response = await _httpClient.PostAsync($`"{_configuration[`"CommandService`"]}`", httpContent);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(`"-->Sync POST to CommandService was OK`");
            }
            else
            {
                Console.WriteLine(`"-->Sync POST to CommandService was NOT OK`");
            }
        }
    }
}"

mkdir Http
cd Http

New-Item -Path . -Name "ICommandDataClient.cs" -ItemType "file" -Value "using System.Threading.Tasks;
using $($ProjectName)Service.Dtos;

namespace $($ProjectName)Service.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task Send$($ProjectName)ToCommand($($ProjectName)ReadDto plat);
    }
}"

cd..
cd..
del WeatherForecast.cs
del appsettings.Development.json
del Startup.cs

# Setting up Api in Appsettings
New-Item -Path . -Name "appsettings.Development.json" -ItemType "file" -Value "{
  `"Logging`": {
    `"LogLevel`": {
      `"Default`": `"Information`",
      `"Microsoft`": `"Warning`",
      `"Microsoft.Hosting.Lifetime`": `"Information`"
    }
  },
  `"CommandService`": `"http://localhost:6000/api/c/$($ProjectName)/`"
}"

New-Item -Path . -Name "appsettings.Production.json" -ItemType "file" -Value "{
  `"CommandService`": `"commands-clusterip-srv:80/api/c/$($ProjectName)/`"
}"

New-Item -Path . -Name "Startup.cs" -ItemType "file" -Value "using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using $($ProjectName)Service.Data;
using $($ProjectName)Service.SyncDataServices.Http;

namespace $($ProjectName)Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseInMemoryDatabase(`"InMem`"));

            services.AddScoped<I$($ProjectName)Repo, $($ProjectName)Repo>();
            services.AddHttpClient<ICommandDataClient, HttpCommandDataClient>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(`"v1`", new OpenApiInfo { Title = `"$($ProjectName)Service`", Version = `"v1`" });
            });

            Console.WriteLine($`"--> CommandService Endpoint {Configuration[`"CommandService`"]}`");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint(`"/swagger/v1/swagger.json`", `"$($ProjectName)Service v1`"));
            //}

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            PrepDb.PrepPopulation(app);
        }
    }
}"