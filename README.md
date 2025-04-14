# FormulaOneRaceVisualizer

# 🧪 Running the Application Locally

This guide provides step-by-step instructions for running the ASP.NET application on your local machine using the .NET CLI or Visual Studio.

---

## 🛠 Prerequisites

Ensure the following tools are installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or later recommended)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional, for development)

---

## ▶️ Run the Application

### Option 1: Using the .NET CLI

1. Open a terminal or command prompt.
2. Navigate to the root directory of the project (where the `.csproj` file is located).
3. Run the following commands:

    ```bash
    dotnet restore    # Restores project dependencies
    dotnet build      # Builds the application
    dotnet run        # Runs the application
    ```

4. You should see output similar to:

    ```
    Building...
    info: Microsoft.Hosting.Lifetime[14]
          Now listening on: https://localhost:5001
          Now listening on: http://localhost:5000
          Application started. Press Ctrl+C to shut down.
    ```

---

### Option 2: Using Visual Studio

1. Open the solution file (`.sln`) in Visual Studio.
2. In the **Solution Explorer**, right-click the main project and select **Set as Startup Project** (if not already).
3. Press `F5` or click the green **Start Debugging** button.

---

## 🌐 Access the Application

Once running, endpoints can be tested at: http://localhost:5258/


> The exact URL and port can be changed int the launch profile or `launchSettings.json`.

---

## ✅ Done!

Your ASP.NET application should now be running locally. If you encounter any issues, double-check your SDK version and project path.


