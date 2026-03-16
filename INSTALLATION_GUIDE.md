# QLSANCL Badminton Management System - Complete Installation Guide

## Table of Contents
1. [System Requirements](#system-requirements)
2. [Step-by-Step Installation](#step-by-step-installation)
3. [File Organization](#file-organization)
4. [Building the Project](#building-the-project)
5. [Troubleshooting](#troubleshooting)

---

## System Requirements

### Required Software:
- **Operating System**: Windows 10 version 1809 or later, Windows 11
- **Visual Studio**: Visual Studio 2022 (Community, Professional, or Enterprise)
- **.NET SDK**: .NET 10.0 SDK
- **Disk Space**: At least 5 GB free space
- **RAM**: Minimum 4 GB (8 GB recommended)

### Visual Studio Workloads:
Make sure you have the following workload installed in Visual Studio:
- .NET desktop development

---

## Step-by-Step Installation

### Step 1: Install Visual Studio 2022

1. Download Visual Studio 2022 from: https://visualstudio.microsoft.com/downloads/
2. Run the installer
3. Select ".NET desktop development" workload
4. Click "Install" and wait for completion

### Step 2: Verify .NET 10 SDK

1. Open Command Prompt or PowerShell
2. Run: `dotnet --list-sdks`
3. Verify .NET 10.0 is listed
4. If not, download from: https://dotnet.microsoft.com/download/dotnet/10.0

### Step 3: Create New WPF Project

1. Open Visual Studio 2022
2. Click "Create a new project"
3. Search for "WPF Application" or "WPF App (.NET)"
4. Click "Next"
5. Configure your new project:
   - **Project name**: `QLSANCL.BadmintonManagement`
   - **Location**: Choose your preferred location
   - **Solution name**: `QLSANCL.BadmintonManagement`
6. Click "Next"
7. **Framework**: Select `.NET 10.0 (Long-term support)`
8. Click "Create"

### Step 4: Install NuGet Packages

**Method 1: Using Package Manager Console**

1. Go to `Tools` → `NuGet Package Manager` → `Package Manager Console`
2. Run the following commands one by one:

```powershell
Install-Package MaterialDesignThemes -Version 5.1.0
Install-Package MaterialDesignColors -Version 3.1.0
Install-Package LiveCharts.Wpf -Version 0.9.7
Install-Package Microsoft.Xaml.Behaviors.Wpf -Version 1.1.122
```

**Method 2: Using NuGet Package Manager UI**

1. Right-click on the project in Solution Explorer
2. Select "Manage NuGet Packages"
3. Click "Browse" tab
4. Search and install each package:
   - MaterialDesignThemes (v5.1.0)
   - MaterialDesignColors (v3.1.0)
   - LiveCharts.Wpf (v0.9.7)
   - Microsoft.Xaml.Behaviors.Wpf (v1.1.122)

### Step 5: Create Folder Structure

1. In Solution Explorer, right-click on the project
2. Select `Add` → `New Folder`
3. Create the following folders:
   - `Models`
   - `ViewModels`
   - `Views`
   - `Helpers` (optional for future use)

Your project structure should look like:
```
QLSANCL.BadmintonManagement/
├── Models/
├── ViewModels/
├── Views/
├── Helpers/
├── App.xaml
├── MainWindow.xaml
└── QLSANCL.BadmintonManagement.csproj
```

### Step 6: Add Code Files

#### A. Replace App.xaml
1. Open `App.xaml` in your project
2. Delete all existing content
3. Copy and paste the content from the provided `App.xaml` file

#### B. Replace App.xaml.cs
1. Open `App.xaml.cs`
2. Replace with the provided code

#### C. Replace MainWindow.xaml
1. Open `MainWindow.xaml`
2. Replace with the provided code

#### D. Replace MainWindow.xaml.cs
1. Open `MainWindow.xaml.cs`
2. Replace with the provided code

#### E. Add Model Classes

For each model file:
1. Right-click on `Models` folder
2. Select `Add` → `Class`
3. Name the file (e.g., `Court.cs`)
4. Replace the generated code with the provided code

Add these files:
- `Court.cs`
- `Booking.cs`
- `Customer.cs`
- `Staff.cs`
- `Service.cs`

#### F. Add ViewModel Classes

For each ViewModel file:
1. Right-click on `ViewModels` folder
2. Select `Add` → `Class`
3. Name the file (e.g., `BaseViewModel.cs`)
4. Replace with provided code

Add these files:
- `BaseViewModel.cs`
- `DashboardViewModel.cs`
- `BookingViewModel.cs`
- `CustomersViewModel.cs`

#### G. Add View Pages

For each View:
1. Right-click on `Views` folder
2. Select `Add` → `New Item`
3. Choose "Page (WPF)"
4. Name it (e.g., `DashboardView.xaml`)
5. Click "Add"
6. Replace the XAML content with provided code
7. Replace the code-behind (.xaml.cs) with provided code

Add these Views:
- `DashboardView.xaml` + `.xaml.cs`
- `BookingView.xaml` + `.xaml.cs`
- `CustomersView.xaml` + `.xaml.cs`
- `ServicesView.xaml` + `.xaml.cs`
- `StaffView.xaml` + `.xaml.cs`
- `ReportsView.xaml` + `.xaml.cs`

---

## File Organization

### Complete File List and Locations

```
QLSANCL.BadmintonManagement/
│
├── App.xaml                           [Replace existing]
├── App.xaml.cs                        [Replace existing]
├── MainWindow.xaml                    [Replace existing]
├── MainWindow.xaml.cs                 [Replace existing]
├── QLSANCL.BadmintonManagement.csproj [Auto-generated/Reference only]
│
├── Models/
│   ├── Court.cs                       [New file]
│   ├── Booking.cs                     [New file]
│   ├── Customer.cs                    [New file]
│   ├── Staff.cs                       [New file]
│   └── Service.cs                     [New file]
│
├── ViewModels/
│   ├── BaseViewModel.cs               [New file]
│   ├── DashboardViewModel.cs          [New file]
│   ├── BookingViewModel.cs            [New file]
│   └── CustomersViewModel.cs          [New file]
│
└── Views/
    ├── DashboardView.xaml             [New file]
    ├── DashboardView.xaml.cs          [New file]
    ├── BookingView.xaml               [New file]
    ├── BookingView.xaml.cs            [New file]
    ├── CustomersView.xaml             [New file]
    ├── CustomersView.xaml.cs          [New file]
    ├── ServicesView.xaml              [New file]
    ├── ServicesView.xaml.cs           [New file]
    ├── StaffView.xaml                 [New file]
    ├── StaffView.xaml.cs              [New file]
    ├── ReportsView.xaml               [New file]
    └── ReportsView.xaml.cs            [New file]
```

---

## Building the Project

### Step 1: Build Solution

1. Click `Build` → `Build Solution` (or press `Ctrl+Shift+B`)
2. Check the Output window for any errors
3. If errors occur, check the [Troubleshooting](#troubleshooting) section

### Step 2: Run Application

1. Press `F5` to run with debugging
   OR
2. Press `Ctrl+F5` to run without debugging

### Expected Result:
- Application window opens with navy blue sidebar on the left
- Dashboard page displays by default
- You can navigate between pages using sidebar buttons
- Court status grid shows 8 courts
- Stats cards display sample data

---

## Troubleshooting

### Issue 1: "The type or namespace name 'MaterialDesign' could not be found"

**Solution:**
1. Verify MaterialDesignThemes package is installed
2. Check App.xaml has MaterialDesign resource dictionaries
3. Rebuild solution (Ctrl+Shift+B)

### Issue 2: "The name 'DashboardView' does not exist in the namespace"

**Solution:**
1. Ensure all View files are created in the `Views/` folder
2. Check namespace in View .xaml.cs files matches: `QLSANCL.BadmintonManagement.Views`
3. Rebuild solution

### Issue 3: MaterialDesign icons not displaying

**Solution:**
1. Verify MaterialDesignThemes and MaterialDesignColors packages are installed
2. Check App.xaml includes MaterialDesign resource dictionaries
3. Clean and rebuild solution:
   - `Build` → `Clean Solution`
   - `Build` → `Rebuild Solution`

### Issue 4: Navigation not working

**Solution:**
1. Check MainWindow.xaml.cs has all navigation cases in `NavigationButton_Checked` method
2. Verify Frame element exists: `<Frame x:Name="MainFrame" .../>`
3. Ensure all View pages inherit from `Page` not `Window`

### Issue 5: Data not displaying in DataGrids

**Solution:**
1. Check DataContext is set in View constructor
2. Verify ViewModel properties match XAML bindings
3. Ensure ObservableCollection is initialized in ViewModel constructor

### Issue 6: Build errors about .NET 10

**Solution:**
1. Update .csproj file: `<TargetFramework>net10.0-windows</TargetFramework>`
2. If .NET 10 SDK not available, change to: `net8.0-windows` or `net9.0-windows`
3. Update Visual Studio to latest version

### Issue 7: "LiveCharts" namespace errors

**Solution:**
- LiveCharts is optional for charts
- Remove LiveCharts references from ReportsView.xaml if not using:
  ```xml
  xmlns:lvc="clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf"
  ```

---

## Additional Configuration

### Changing Window Title
Edit `MainWindow.xaml`:
```xml
<Window ... Title="Your Custom Title Here">
```

### Changing Default Page
Edit `MainWindow.xaml.cs` constructor:
```csharp
MainFrame.Navigate(new BookingView()); // Change from DashboardView
```

### Adding New Navigation Item

1. **Add RadioButton in MainWindow.xaml:**
```xml
<RadioButton x:Name="NewPageNav" Content="New Page" Tag="NewPage" 
             Style="{StaticResource NavButtonStyle}" 
             Checked="NavigationButton_Checked">
```

2. **Add case in MainWindow.xaml.cs:**
```csharp
case "NewPage":
    MainFrame.Navigate(new NewPageView());
    break;
```

3. **Create NewPageView.xaml and .xaml.cs in Views folder**

---

## Running in Production

### Publishing the Application

1. Right-click project in Solution Explorer
2. Select "Publish"
3. Choose "Folder" as target
4. Select output location
5. Click "Publish"
6. Executable will be in: `bin\Release\net10.0-windows\publish\`

### Creating Installer (Optional)

Use tools like:
- **WiX Toolset** - Open source Windows installer
- **Advanced Installer** - Commercial installer creator
- **Inno Setup** - Free installer script

---

## Support and Resources

### Official Documentation:
- WPF: https://docs.microsoft.com/en-us/dotnet/desktop/wpf/
- Material Design: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit
- LiveCharts: https://lvcharts.net/

### Common Commands:

**Build:**
```powershell
dotnet build
```

**Run:**
```powershell
dotnet run
```

**Restore packages:**
```powershell
dotnet restore
```

---

## Next Steps

After successful installation:

1. **Customize Sample Data**: Replace mock data in ViewModels with real data
2. **Add Database**: Integrate Entity Framework Core with SQL Server
3. **Implement Features**: Add create/edit/delete operations
4. **Add Validation**: Implement input validation for forms
5. **Error Handling**: Add try-catch blocks and error messages
6. **Testing**: Create unit tests for ViewModels

---

## Version History

- **v1.0.0** (March 2026) - Initial release

---

## Contact

For technical support or questions:
- Email: support@qlsancl.com
- Documentation: [Include link to online docs]

---

**Congratulations!** You have successfully installed the QLSANCL Badminton Management System.
