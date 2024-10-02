# Gateways test backend application

This solution has:
- An Architecture designed for scalability, maintenance and flexibility, with the use of patterns
- Unit and integration tests.
- Data initialized since run

## Installation guide

- Install .Net 6.0 or higher
- Navigate to the project folder root (`cd gateways-net`)
- Install the project dependencies (`dotnet restore`)
- Build the project (`dotnet build`)
- Run the project (`dotnet run --project Gateways.Api`)
- Open browser and navigate to <https://localhost:7114/swagger>


## Open Postman and test the operations in the collection

- Import postman_collection.json file into Postman
- Run each endpoint in the order provided