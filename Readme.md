# Truck Register

Truck register is a sample application built using ASP.NET Core and Entity Framework Core based on Northwind traders project explained in the following video:

* [Developing Enterprise Apps with ASP.NET Core 2.1](https://youtu.be/fAJrVf8f6M4)

## Getting Started
Use these instuctions to get the project up and running.

### Prerequisites
You will need the following tools:

* [Visual Studio Code or 2017](https://www.visualstudio.com/downloads/)
* [.NET Core SDK 2.2 Preview 2](https://www.microsoft.com/net/download/dotnet-core/2.2)

### Setup
Follow these steps to get your development environment set up:

  1. Clone the repository
  2. At the root directory, restore required packages by running:
     ```
     dotnet restore
     ```
  3. Next, build the solution by running:
     ```
     dotnet build
     ```
  4. Next, within the `Northwind.WebUI\ClientApp` directory, launch the front end by running:
     ```
     npm start
     ```
  5. Once the front end has started, within the `Northwind.WebUI` directory, launch the back end by running:
     ```
	 dotnet run
	 ```
  5. Launch [http://localhost:52468/](http://localhost:52468/) in your browser to view the Web UI
  
  6. Launch [http://localhost:52468/api](http://localhost:52468/api) in your browser to view the API

## Technologies
* [.NET Core 2.2](https://blogs.msdn.microsoft.com/dotnet/2018/09/12/announcing-net-core-2-2-preview-2/)
* [ASP.NET Core 2.2](https://blogs.msdn.microsoft.com/webdev/2018/08/22/asp-net-core-2-2-0-preview1-now-available/)
* [Entity Framework Core 2.2](https://blogs.msdn.microsoft.com/dotnet/2018/09/12/announcing-entity-framework-core-2-2-preview-2/)