# Library Management System

A simple Library Management System built with C# and WPF.

This project allows users to add and manage different types of library items, including books, magazines, and DVDs.

## Features

- Add books to the library
- Add magazines to the library
- Add DVDs to the library
- Display all added items in a ListBox
- Dynamically change the details label based on the selected item type
- Validate numeric input for magazine issue numbers
- Validate numeric input for DVD durations
- Use generics to manage different types of library items
- Display item details based on their type

## Supported Item Types

### Book

A book contains:

- Title
- Author

Example:

`Title: Clean Code - Author: Robert - Type: Book`

### Magazine

A magazine contains:

- Title
- Issue Number

Example:

`Title: Time Magazine - Issue Number: 5 - Type: Magazine`

### DVD

A DVD contains:

- Title
- Duration

Example:

`Title: Inception - Duration: 148 - Type: DVD`

## Technologies Used

- C#
- .NET
- WPF
- XAML
- Object-Oriented Programming (OOP)
- Generics

## Project Structure

    LibraryManagementSystem
    │
    ├── Models
    │   ├── Book.cs
    │   ├── Magazine.cs
    │   ├── DVD.cs
    │   └── LibraryItem.cs
    │
    ├── Library.cs
    ├── LibraryManager.cs
    ├── MainWindow.xaml
    ├── MainWindow.xaml.cs
    └── README.md

## How It Works

1. Select an item type from the ComboBox.
2. Enter the title of the item.
3. Enter the required details based on the selected item type:
   - Author for a book
   - Issue Number for a magazine
   - Duration for a DVD
4. Click the **Add** button.
5. The item is added to the library.
6. The library items are displayed in the ListBox.

## Generic Implementation

The project uses a generic `LibraryItem<T>` class to store different types of library items.

Examples of supported generic types include:

`LibraryItem<Book>`

`LibraryItem<Magazine>`

`LibraryItem<DVD>`

Using generics allows the application to store different types of details while keeping the implementation flexible and reusable.

## Type Checking

The application uses the C# `is` keyword to check the type of an item's details.

For example, the application checks whether the details belong to a Book, Magazine, or DVD and displays the appropriate information.

This allows each library item to display its specific properties, such as:

- Author for a Book
- Issue Number for a Magazine
- Duration for a DVD

## User Interface

The WPF user interface includes:

- ComboBox for selecting the item type
- TextBox for entering the item title
- TextBox for entering item details
- Dynamic Label that changes based on the selected item type
- Button for adding items
- ListBox for displaying added library items

## Input Validation

The application validates numeric input for:

- Magazine Issue Number
- DVD Duration

The `int.TryParse()` method is used to safely convert user input from a string to an integer.

If the entered value is not a valid number, the application displays an error message.

## Learning Objectives

This project was created to practice and improve knowledge of:

- C# classes and objects
- Object-Oriented Programming
- Generics
- Generic classes
- Methods
- Lists
- `List<object>`
- Type checking with the `is` keyword
- Method parameters
- Event handling
- WPF
- XAML
- ComboBox
- TextBox
- Label
- Button
- ListBox
- SelectionChanged events
- Click events
- Displaying objects using `ToString()`
- Input validation using `int.TryParse()`

## Future Improvements

Possible future improvements include:

- Edit existing library items
- Remove library items
- Search for library items
- Add more input validation
- Clear input fields after adding an item
- Improve the user interface
- Add icons and styling
- Implement the MVVM pattern
- Store data in a database
- Add Entity Framework Core
- Add SQL Server support
- Save library items permanently
- Add categories for library items

## Author

**Shokoofa Tagharobian**

.NET Backend Developer

## Purpose

This project was created as a learning project to practice C#, Generics, Object-Oriented Programming, and WPF.

The main goal of this project is to understand how generic classes can be used to manage different types of objects and how those objects can be displayed and managed through a WPF user interface.
