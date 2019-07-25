# NetCoreWebApi
[![Build status](https://ci.appveyor.com/api/projects/status/g3yrhq2st5v8fx8t/branch/master?svg=true)](https://ci.appveyor.com/project/nallonp/netcorerest-api/branch/master)
![Nuget](https://img.shields.io/nuget/v/WebStore.svg)
[![Coverage Status](https://coveralls.io/repos/github/nallonp/NetCoreREST-API/badge.svg?branch=master)](https://coveralls.io/github/nallonp/NetCoreREST-API?branch=master)

Projeto de API do curso da Programmers.

## How to install:

Via "Package Manager Console" type the following:
```powershell
Install-Package WebStore
```
## How to use:

Setup the dependencies via injection:
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
