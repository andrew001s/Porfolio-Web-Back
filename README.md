
# Portfolio Management Service

![.NET Version](https://img.shields.io/badge/.NET-8.0-blue)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Code%20First-green)
![MySQL](https://img.shields.io/badge/Database-MySQL-orange)


## Overview

This service is designed to manage my projects and work experience, which are showcased on my portfolio website. Built with .NET 8 and Entity Framework, it uses a code-first approach to manage data in a MySQL database.

## Table of Contents

- [Technologies](#technologies)
- [Project Structure](#project-structure)
- [Database Schema](#database-schema)
- [Setup Instructions](#setup-instructions)
- [Usage](#usage)



## Technologies

- **.NET 8**: Core framework for building the web API.
- **Entity Framework Core**: ORM for interacting with MySQL database using a code-first approach.
- **MySQL**: Relational database used for storing projects and work experience data.

## Project Structure

The project is organized using a classic structure with Controllers, Services, and Models:

```
/Controllers
    - ProjectsController.cs
    - ExperienceController.cs
/Services
    - IProjectsServices.cs
    - IExperienceServices.cs
    - ProjectsServices.cs
    - ExperienceServices.cs
/Models
    - Projects.cs
    - Experience.cs
```

## Database Schema

The database consists of two primary tables:

1. **Projects**
   - Stores data related to the various projects.
   - Fields: `Id`, `Name`, `Description`, `Image`, `Url`, `Tech`.

2. **Experience**
   - Records details of work experience.
   - Fields: `Id`, `Company`, `Position`, `Description`, `Date`.

## Setup Instructions

Follow these steps to get the project up and running locally:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/portfolio-management-service.git
   cd portfolio-management-service
   ```

2. **Configure MySQL Database**:
   - Ensure MySQL is installed and running.
   - Update the `appsettings.json` file with your MySQL connection string.



## Usage

Once the application is running, you can interact with the API via the following endpoints:

- `/api/Proyect` -  operations for managing projects.
- `/api/Experience` -  operations for managing work experience.


