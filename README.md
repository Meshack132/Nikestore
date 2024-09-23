 NikeStore project:

---

# NikeStore

**NikeStore** is an ASP.NET Core web application for purchasing Nike sneakers and t-shirts online. The application allows users to browse the latest Nike products, add them to their cart, and securely checkout.

## Features

- Browse Nike sneakers and t-shirts
- Product search functionality
- Add to cart and view cart summary
- Checkout process with payment gateway integration
- Admin dashboard for managing products and orders

## Technologies Used

- **ASP.NET Core 6.0**
- **Entity Framework Core** for database management
- **SQL Server** as the database
- **Docker** for containerization
- **Bootstrap** for responsive design

## Prerequisites

To run this project, you will need the following:

- [.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Docker](https://www.docker.com/products/docker-desktop) (optional for running the app in a container)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (optional for development)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Meshack132/Nikestore.git
   cd Nikestore
   ```

2. Set up the database by applying migrations:
   ```bash
   dotnet ef database update
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Visit `http://localhost:5000` in your browser to see the application.

## Docker Support

To run the application in a Docker container:

1. Build the Docker image:
   ```bash
   docker build -t nikestore .
   ```

2. Run the container:
   ```bash
   docker run -d -p 80:80 nikestore
   ```

## Testing

Unit and integration tests are included in the `NikeStore.Tests` project. To run tests, use the following command:

```bash
dotnet test
```

