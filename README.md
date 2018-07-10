# palindrome-checker
A .Net Core C# application that checks if a user input string is a palindrome.

#### Important 
Please run the following commands in PMC before running the app:

```
Add-Migration Initial  
Update-Database
```

#### Notes:

* Front end is created with **Bootstrap 4** and **angular 4**.
* The backend is a **.Net Core Web API**.
* Microsoft **Unity** is used as dependency injection tool.
* Microsoft **Entity Framework** is used as ORM tool.
* All successfully entered palindromes are persisted in local db.
* A screen is provided to lists all known palindromes from the persisted list.
* **MS Test** is used for a unit testing.
