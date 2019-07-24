# NetCoreWebApi
[![Build status](https://ci.appveyor.com/api/projects/status/g3yrhq2st5v8fx8t/branch/master?svg=true)](https://ci.appveyor.com/project/nallonp/netcorerest-api/branch/master)

I'm just learning to build REST APIS.

## How to install:

Via "Package Manager Console" type the following:
Install-Package WebStore -Version 1.0.0

## How to use:

Setup the depencies via injection:
```cs
private void DependencyInjection(IServiceCollection services)
  {
    services.AddSingleton<ICarRepository, CarRepository>();
    services.AddTransient<ICarBusiness, CarBusiness>();
    services.AddTransient<ICarService, CarService>()
  }
```
Use methods from services classes to manipulate objects:
```cs
  _service.Add(car);
```
