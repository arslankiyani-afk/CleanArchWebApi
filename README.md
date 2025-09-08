# CleanArchWebApi

This repository implements a Clean Architecture Web API for managing Dome entities, featuring CRUD operations and a modular, testable structure. Key layers include Presentation, Application, Domain, and Infrastructure.

## Layers and Project Structure

- **Domain**: Contains core business entities (`Dome`) and logic.
- **Application**: Contains service interfaces (`IDomeService`) and application logic for Dome CRUD operations.
- **Infrastructure**: Implements data access/repository interfaces (`IDomeRepository`) and in-memory data storage.
- **Presentation**: ASP.NET Core Controllers for API endpoints (`DomeController`).

```
src/
├── Domain/
│   └── Entities/
│       └── Dome.cs
├── Application/
│   └── Interfaces/
│       └── IDomeService.cs
├── Infrastructure/
│   └── Interfaces/
│       └── IDomeRepository.cs
│   └── Repositories/
│       └── DomeRepository.cs
├── Presentation/
│   └── Controllers/
│       └── DomeController.cs
```

## Dome Entity

The `Dome` entity typically contains:
- `Id`: int
- `Name`: string
- `Description`: string

## Dome CRUD Endpoints

- `POST /api/dome` — Create a new Dome
- `GET /api/dome/{id}` — Get a Dome by ID
- `GET /api/dome` — List all Domes
- `PUT /api/dome/{id}` — Update a Dome
- `DELETE /api/dome/{id}` — Delete a Dome

## Example Usage

### Create a Dome

```http
POST /api/dome
Content-Type: application/json

{
  "name": "Example Dome",
  "description": "This is a sample dome."
}
```

### Get Dome by ID

```http
GET /api/dome/1
```

## Technologies

- ASP.NET Core
- C#
- Clean Architecture principles

## Getting Started

1. Clone the repo:
   ```
   git clone https://github.com/arslankiyani-afk/CleanArchWebApi.git
   ```
2. Build and run the project:
   ```
   dotnet build
   dotnet run
   ```
3. Access API endpoints via Swagger or your preferred API tool.

## License

MIT License
