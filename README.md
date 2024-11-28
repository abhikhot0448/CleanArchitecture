# Activity Tracker - .NET Core 8 Web API

## Overview
This project is an **Activity Tracker** built using **.NET Core 8 Web API** with a focus on **Clean Architecture** principles. It aims to help users track, manage, and analyze various activities efficiently.

## Technologies Used
- **.NET Core 8**
- **Clean Architecture**
- **Entity Framework Core**
- **PostgreSQL**
- **MediatR** for CQRS
- **Swagger** for API documentation

## Project Structure
/src /Application -> Business logic, Use Cases /Domain -> Entities, Aggregates, Enums /Infrastructure -> Data access, Repositories, EF Core (if applicable) /WebAPI -> API controllers, Startup configuration /tests /Application.Tests -> Unit tests for Application layer /WebAPI.Tests -> Integration tests for API

## Features
- **User Management:** Register, Login, Update Profile
- **Activity Tracking:** Create, Update, Delete, and View Activities
- **Reporting:** Generate activity reports by date, type, etc.


