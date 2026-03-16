# QLSANCL - Badminton Court Management System (WPF .NET 10)

## Project Overview
A comprehensive desktop application for managing badminton court operations, built with C# WPF and .NET 10.

## Features
- **Dashboard**: Real-time court status, statistics, and recent bookings
- **Booking Management**: Schedule courts with casual and fixed subscription options
- **Services & POS**: Sell drinks and equipment with billing system
- **Customer Management**: Track customer profiles and booking history
- **Staff Management**: Employee directory and user account administration
- **Reports & Analytics**: Business insights with charts and KPIs

## Prerequisites
- Visual Studio 2022 (or later)
- .NET 10.0 SDK
- Windows 10/11

## Setup Instructions

### 1. Create New WPF Project in Visual Studio
1. Open Visual Studio 2022
2. Click "Create a new project"
3. Select "WPF Application" template
4. Project name: `QLSANCL.BadmintonManagement`
5. Framework: .NET 10.0
6. Click "Create"

### 2. Install Required NuGet Packages
Open Package Manager Console (Tools → NuGet Package Manager → Package Manager Console) and run:

```powershell
Install-Package MaterialDesignThemes -Version 5.1.0
Install-Package MaterialDesignColors -Version 3.1.0
Install-Package LiveCharts.Wpf -Version 0.9.7
Install-Package Microsoft.Xaml.Behaviors.Wpf -Version 1.1.122
```

### 3. Create Project Structure
Create the following folders in your project:
- `Models`
- `ViewModels`
- `Views`
- `Helpers`

### 4. Add All Code Files
Copy all the provided files into their respective folders:

#### Root Files:
- `App.xaml` and `App.xaml.cs`
- `MainWindow.xaml` and `MainWindow.xaml.cs`

#### Models/ Folder:
- `Court.cs`
- `Booking.cs`
- `Customer.cs`
- `Staff.cs`
- `Service.cs`

#### ViewModels/ Folder:
- `BaseViewModel.cs`
- `DashboardViewModel.cs`
- `BookingViewModel.cs`
- `CustomersViewModel.cs`

#### Views/ Folder:
- `DashboardView.xaml` and `DashboardView.xaml.cs`
- `BookingView.xaml` and `BookingView.xaml.cs`
- `CustomersView.xaml` and `CustomersView.xaml.cs`
- `ServicesView.xaml` and `ServicesView.xaml.cs`
- `StaffView.xaml` and `StaffView.xaml.cs`
- `ReportsView.xaml` and `ReportsView.xaml.cs`

### 5. Build and Run
1. Press `F6` to build the solution
2. Fix any namespace errors if they occur
3. Press `F5` to run the application

## Project Structure

```
QLSANCL.BadmintonManagement/
├── App.xaml                    # Application resources and styles
├── App.xaml.cs                 # Application entry point
├── MainWindow.xaml             # Main window with sidebar navigation
├── MainWindow.xaml.cs          # Main window code-behind
├── Models/
│   ├── Court.cs               # Court entity model
│   ├── Booking.cs             # Booking entity model
│   ├── Customer.cs            # Customer entity model
│   ├── Staff.cs               # Staff entity model
│   └── Service.cs             # Service and CartItem models
├── ViewModels/
│   ├── BaseViewModel.cs       # Base ViewModel with INotifyPropertyChanged
│   ├── DashboardViewModel.cs  # Dashboard data and logic
│   ├── BookingViewModel.cs    # Booking management logic
│   └── CustomersViewModel.cs  # Customer management logic
└── Views/
    ├── DashboardView.xaml     # Dashboard page
    ├── BookingView.xaml       # Booking management page
    ├── CustomersView.xaml     # Customer management page
    ├── ServicesView.xaml      # POS and services page
    ├── StaffView.xaml         # Staff management page
    └── ReportsView.xaml       # Reports and analytics page
```

## Color Scheme
- **Navy Blue**: `#0F172A`, `#1E293B` (Sidebar, primary elements)
- **Lime Green**: `#84CC16`, `#A3E635` (Accents, buttons, highlights)
- **Background**: `#F8FAFC` (Light gray background)

## Design Patterns
- **MVVM (Model-View-ViewModel)**: Separates UI from business logic
- **INotifyPropertyChanged**: Enables two-way data binding
- **Navigation Pattern**: Frame-based page navigation

## Customization

### Adding a New Page
1. Create a new Page in `Views/` folder
2. Create corresponding ViewModel in `ViewModels/` folder
3. Add navigation button in `MainWindow.xaml`
4. Add navigation case in `MainWindow.xaml.cs`

### Modifying Colors
Edit the color resources in `App.xaml`:
```xml
<SolidColorBrush x:Key="NavyBlueBrush" Color="#0F172A"/>
<SolidColorBrush x:Key="LimeGreen" Color="#84CC16"/>
```

### Connecting to Database
Replace mock data in ViewModels with actual database calls:
1. Install Entity Framework Core NuGet package
2. Create DbContext class
3. Update ViewModels to use DbContext
4. Configure connection string in App.config

## Data Binding Examples

### Binding to ViewModel Property:
```xml
<TextBlock Text="{Binding DailyRevenue, StringFormat='₫{0:N0}'}"/>
```

### Binding to Collection:
```xml
<DataGrid ItemsSource="{Binding Customers}" />
```

### Two-Way Binding:
```xml
<TextBox Text="{Binding SearchText, UpdateSourceTrigger=PropertyChanged}"/>
```

## Common Issues and Solutions

### Issue: MaterialDesign icons not showing
**Solution**: Make sure MaterialDesignThemes NuGet package is installed and referenced correctly in App.xaml

### Issue: Navigation not working
**Solution**: Ensure all View pages have correct namespace and class names matching the XAML

### Issue: Data not displaying
**Solution**: Verify DataContext is set correctly in View code-behind constructor

## Future Enhancements
- Database integration (SQL Server, SQLite, or PostgreSQL)
- Real-time updates using SignalR
- Print functionality for invoices and reports
- Email/SMS notifications
- Multi-language support
- Advanced reporting with chart libraries
- Payment gateway integration
- User authentication and authorization

## License
This project is for educational and commercial use.

## Support
For issues or questions, contact: support@qlsancl.com

## Version
1.0.0 - Initial Release (March 2026)
