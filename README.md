# UserManagementAPI — Final Project (Coursera)

This project was developed as part of a three‑activity backend development module.  
It includes full CRUD functionality, debugging improvements, validation, custom middleware, and documentation.

---

## 🚀 Project Overview

TechHive Solutions requires an internal API to help HR and IT manage user records efficiently.  
This API supports:

- Creating users  
- Retrieving users  
- Updating users  
- Deleting users  
- Validating input data  
- Logging requests and responses  
- Handling errors consistently  
- Token‑based authentication (middleware included)

The project was built using **ASP.NET Core Web API**, with **Microsoft Copilot** assisting in code generation, debugging, and enhancement.

---

## 🧩 Technologies Used

- .NET 8  
- ASP.NET Core Web API  
- Swagger / OpenAPI  
- Custom Middleware  
- DataAnnotations for validation  
- C# 12  

---

## 📁 Project Structure


Project Structure
UserManagementAPI/
├── Controllers/
│   └── UsersController.cs
├── Middleware/
│   ├── LoggingMiddleware.cs
│   ├── ErrorHandlingMiddleware.cs
│   └── AuthenticationMiddleware.cs
├── Models/
│   └── User.cs
├── Services/
│   └── UserService.cs
├── Program.cs
└── UserManagementAPI.csproj

Actividad 1 — Writing & Enhancing API Code (COMPLETADA)


---

## 🟦 Activity 1 — Writing & Enhancing API Code (COMPLETED)

### ✔ What was done

- Created the `UserManagementAPI` project.
- Used Copilot to scaffold the initial setup (Program.cs, basic structure).
- Implemented full CRUD endpoints:
  - `GET /api/users`
  - `GET /api/users/{id}`
  - `POST /api/users`
  - `PUT /api/users/{id}`
  - `DELETE /api/users/{id}`
- Tested endpoints using Swagger (POST returned 201 Created).
- Applied Copilot suggestions to improve clarity and structure.

### ✔ How Copilot helped

- Generated the base controller with CRUD methods.
- Suggested the structure for `UserService`.
- Improved Program.cs configuration (services, Swagger).
- Helped refine routes, return types, and JSON structure.

---

## 🟩 Activity 2 — Debugging API Code (COMPLETED)

### ✔ Issues found and fixed

- Missing validation in the `User` model.
- `GetById` returned null without handling → now returns 404.
- Nullable warnings fixed using `= string.Empty`.
- Swagger/OpenAPI issues resolved by adjusting framework and packages.
- Unhandled exceptions fixed using error‑handling middleware.
- POST returning 401 fixed by adjusting middleware order.

### ✔ How Copilot helped

- Identified properties requiring initialization.
- Suggested changing `User` → `User?` in the service.
- Recommended adding DataAnnotations.
- Detected incorrect middleware order.
- Proposed centralized error handling.

---

## 🟥 Activity 3 — Middleware Implementation (COMPLETED)

### ✔ Middleware implemented

#### 1. LoggingMiddleware  
Logs:
- HTTP method  
- Request path  
- Response status code  

#### 2. ErrorHandlingMiddleware  
- Catches unhandled exceptions  
- Returns consistent JSON:  
  `{ "error": "Internal server error." }`

#### 3. AuthenticationMiddleware  
- Validates token from the Authorization header  
- Returns 401 Unauthorized if invalid  
- Can be enabled or left commented depending on requirements  

### ✔ Correct pipeline order

1. ErrorHandlingMiddleware  
2. AuthenticationMiddleware  
3. LoggingMiddleware  
4. MapControllers  

### ✔ How Copilot helped

- Generated the base structure for each middleware.
- Suggested how to read the response body for logging.
- Ensured the correct middleware order.
- Helped implement token validation logic.

---

## 🧪 How to Run the Project

1. Clone the repository:

2. Navigate into the project:

3. Run the API:

4. Open Swagger UI:  http://localhost:xxxx/swagger




