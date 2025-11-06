# Haver NCR – ASP.NET MVC Web Application

![.NET](https://img.shields.io/badge/.NET-7.0-blue)
![C#](https://img.shields.io/badge/C%23-Language-brightgreen)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-green)
![Azure](https://img.shields.io/badge/Deployed%20On-Azure-blue)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

---

### 🌐 Live Demo  
👉 **[View Deployed App on Azure](https://haverproject1.azurewebsites.net/)**  

---

## 🧩 Overview

**Haver NCR** is a full-stack ASP.NET MVC web application built to streamline **Non-Conformance Report (NCR)** management in a manufacturing environment.  
It enables users to **create, track, analyze, and archive NCRs** while maintaining transparency across multiple departments.  

The project integrates **analytics dashboards, automated emails, file versioning, and REST APIs**, showcasing real-world enterprise workflow automation and reporting.

---

## 🚀 Features

- 🧾 **Create, edit, and archive NCR reports**
- 📊 **Interactive analytics dashboard** using Power BI and Chart.js
- 🔐 **Role-based access control** (Admin, Engineering, Quality, Procurement)
- 📧 **Automated email workflow approval** for NCR submissions
- 📂 **File upload and versioning** for attached reports or evidence
- 📈 **Performance analytics** (Supplier-wise, Part-wise, Monthly/Yearly)
- 🗄️ **Archiving system** for historical NCRs
- 🧮 **Export to PDF and Excel** using iTextSharp and EPPlus
- ☁️ **Deployed on Microsoft Azure** for live demonstration
- 🌐 **API endpoints** for external report integration and automation

---

## 🧠 Technologies Used

- **ASP.NET MVC 7 (C#)**  
- **Entity Framework Core**  
- **SQL Server / LocalDB**  
- **Chart.js / Power BI Embedded**  
- **iTextSharp** – PDF generation  
- **EPPlus** – Excel export  
- **ImageSharp** – image processing  
- **Bootstrap 5 / Razor Views** – UI and frontend  
- **Microsoft Azure App Service** – cloud deployment  
- **SMTP MailKit** – automated email workflow  

---

## ⚙️ Setup & Installation

# Clone the repository
git clone https://github.com/LakshayJakhar/Haver
cd Haver

# Open the solution in Visual Studio 2022 or newer

# Restore required NuGet packages:
# EntityFrameworkCore, iTextSharp, EPPlus, ImageSharp, MailKit, Chart.js

# Configure your database connection in appsettings.json

# Apply migrations
dotnet ef database update

# Build and run the application
# The app will start at: https://localhost:5001

## 🧭 Usage

Navigate to the NCR Dashboard.

Create a new NCR and upload related evidence or documents.

Submit the NCR for email-based approval workflow.

Analyze NCR data using the Power BI / Chart.js dashboards.

Export results as PDF or Excel reports.

Archive or retrieve previous NCRs with version control.

Use API endpoints for external analytics or reporting tools.

## 📊 Analytics & Reporting

Supplier and Part-wise defect analysis

Period-over-period (PoP) and Year-over-Year (YoY) performance trends

Interactive dashboards powered by Chart.js and Power BI

Exportable NCR summaries in PDF and Excel formats

REST API integration for real-time data sharing
