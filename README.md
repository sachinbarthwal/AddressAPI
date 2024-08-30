# Address Management Application

This project consists of an Angular frontend and a .NET Core backend API with RavenDB integration.

## Prerequisites

- Node.js (v14 or later)
- .NET Core SDK 6.0
- Angular CLI (v15)
- RavenDB Server

## RavenDB Setup

1. Download and install RavenDB from https://ravendb.net/download
2. Start the RavenDB server
3. The application is configured to connect to RavenDB at http://localhost:8080. If your RavenDB is running on a different URL, update the `appsettings.json` file in the AddressAPI project accordingly.
4. :warning: **Please make sure RavenDb is installed with AddressDb database else this application will fail**



## Setup Instructions

1. Clone the repository:
 ```
git clone https://github.com/sachinbarthwal/AGDataAssesment.git
cd --YourFolderName--
```
3. Set up the backend:
 ```
cd AddressAPI
dotnet restore
dotnet build
 ```

4. Set up the frontend:
 ```cd ../AngularFrontend
npm install
npm install bootstrap
```

### Running the Application

After completing the setup, you have two options to run the application:

1. **Using the Batch File**:  
   A batch file named `start-app.bat` has been added to the root folder of the project. This file can be used to start both the backend and frontend services with a single command. Simply double-click on `start-app.bat` to run the application.

2. **Using Visual Studio**:  
   Alternatively, you can run the application directly through Visual Studio. Open the solution file in Visual Studio, and start the application by pressing `F5` or using the "Start Debugging" option.
- Right click on solution go to properties, startup project then select Multiple Startup projects and select start for both of both the project and ok.
- Start the backend:
  ```
  cd ../AddressAPI
  dotnet run
  ```
- In a new terminal, start the frontend:
  ```
  cd ../AngularFrontend
  ng serve
  ```

- Open a web browser and navigate to `http://localhost:4200`

## Ports

- The backend API will be available at `https://localhost:7262`
- The frontend will be served at `http://localhost:4200`

## Project Structure

- `AddressAPI/`: .NET Core 6 backend with RavenDB integration
- `AngularFrontend/`: Angular 15 frontend application

## Backend (AddressAPI)

- Built with .NET Core 6
- Uses RavenDB for data persistence
- Implements RESTful API endpoints for address management

## Troubleshooting

- If you encounter CORS issues, ensure that the backend is properly configured to allow requests from the frontend origin.
- Verify that RavenDB is running and accessible at the configured URL before starting the backend.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.

For backend issues, refer to the .NET Core and RavenDB documentation.
