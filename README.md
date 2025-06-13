# ASP.NET MVC Export to CSV Example

This is a simple ASP.NET MVC project that shows how to export a list of products to a CSV (Comma-Separated Values) file. The example is useful for learning how to generate downloadable files from a controller action.

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Objects/Memo.webp" alt="Memo" width="35" height="35" /></a> Features

- Export a hardcoded list of products
- Sort the products by ID
- Generate a CSV file with headers
- Download the CSV directly in the browser

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Objects/Toolbox.webp" alt="Toolbox" width="35" height="35" /></a> Technologies

- ASP.NET MVC 5
- C#
- .NET Framework (or .NET Core, depending on your setup)

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Objects/File%20Folder.webp" alt="File Folder" width="35" height="35" /></a> Structure

- **Models/Products.cs** – Defines the `Products` class with basic properties like `Id`, `Name`, `Description`, and `Price`.
- **Controllers/HomeController.cs** – Contains the `ExportDataToExcel` method that generates and returns the CSV file.
- **Views/Home/Index.cshtml** – (Optional) A view that includes a form or button to trigger the export action.

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Travel%20and%20Places/Rocket.webp" alt="Rocket" width="35" height="35" /></a> How It Works

1. The controller creates a list of sample `Products`.
2. It orders the list by product ID.
3. The list is converted into a CSV string.
4. The CSV file is returned using the `File()` method so the user can download it.


## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Symbols/Check%20Mark%20Button.webp" alt="Check Mark Button" width="35" height="35" /></a> How to Run

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Run the application.
4. Use a form or button (e.g., on the Index view) to send a POST request to `/Home/ExportDataToExcel`.

---
Thanks for checking out this project!  
If you found it helpful, feel free to <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Animals%20and%20Nature/Star.webp" alt="Star" width="15" height="15" /></a> the repo or share it with others.  
Contributions, feedback, and suggestions are always welcome!
<br>
<br>
![Visitor Badge](https://visitor-badge.laobi.icu/badge?page_id=SoheilSadeghii.OpenClosedPrinciple)
