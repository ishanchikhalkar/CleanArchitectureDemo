project references
Application → Domain
dotnet add CleanArchitectureDemo.Application reference CleanArchitectureDemo.Domain
Infrastructure → Application
dotnet add CleanArchitectureDemo.Infrastructure reference CleanArchitectureDemo.Application
Infrastructure → Domain
dotnet add CleanArchitectureDemo.Infrastructure reference CleanArchitectureDemo.Domain
API → Application
dotnet add CleanArchitectureDemo.API reference CleanArchitectureDemo.Application
API → Infrastructure
dotnet add CleanArchitectureDemo.API reference CleanArchitectureDemo.Infrastructure

Now your dependency graph is:

API
│
├── Application
│     │
│     └── Domain
│
└── Infrastructure
      │
      ├── Application
      │
      └── Domain


CleanArchitectureDemo
│
├── API
│   ├── Controllers
│   │   └── CustomersController.cs
│   │
│   ├── Program.cs
│   └── appsettings.json
│
├── Application
│   ├── DTOs
│   │   ├── CustomerDto.cs
│   │   └── CreateCustomerDto.cs
│   │
│   ├── Interfaces
│   │   └── ICustomerRepository.cs
│   │
│   └── Services
│       ├── ICustomerService.cs
│       └── CustomerService.cs
│
├── Domain
│   └── Entities
│       └── Customer.cs
│
└── Infrastructure
    ├── Data
    │   └── ApplicationDbContext.cs
    │
    └── Repositories
        └── CustomerRepository.cs
