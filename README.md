# Fast Food Restaurant

A single page software for fastfood terminal restaurant build using .NET Core and C# with Windows Forms.

<strong>Observation:</strong> This software is under development.


<p align="center">
    <img alt="Project logo" width="20%" src="https://github.com/viniciusmorgado/FastFoodRestaurant/blob/master/src/Assets/Images/logo.png"> 
</p>

## Screenshots

<p align="center">
    <img alt="Screenshot" width="65%" src="https://i.imgur.com/ooQ8csY.png"> 
</p>



## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

This project need the following software install in your local machine to work:

[.NET Core 3.1 or later](https://dotnet.microsoft.com/download)

[Microsoft SQL Server 2019 or later](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

This project is based on Windows Forms, for access the designer tool you will need a Visual Studio IDE, but for modifying the code only you can use any text editor like vscode or atom.

[Visual Studio IDE](https://visualstudio.microsoft.com/pt-br/)

### Installing

For developers that use Visual Studio IDE just clone the repository and double-click on FastFoodRestaurant.sln and project will be loaded.

```
git clone https://github.com/viniciusmorgado/FastFoodRestaurant.git
```

For people that want to run the software, install Microsoft SQL Server and .NET Core SDK, and clone the repository.

After cloning goes to powershell and access the project directory, inside project root write in powershell:

```
dotnet run
```

This command will compile the application and run the software.

<strong>Remember:</strong> If you don´t install SQL Server, database options for data persistence will not be available.

For people who are just curious, an alternative is to download the precompiled version by [clicking here](https://github.com/viniciusmorgado/FastFoodRestaurant/raw/master/_Build/Setup_FastFoodRestaurant.exe), this version is updated monthly and not after minor upgrads.

# System Design Overview #

Below are technical details about interface, architecture, database and other decisions made during the development of the project.

## Architectural Pattern ##

<strong>MVC (Model - View - Controller)</strong>

This project is written using MVC pattern for separations of concerns because you capability of loose coupling, the software layers like model is independent from the user interface (views) accessing data for presentation through controllers class, this approach allow better maintainability and coherence for long-term development.

## UML Schematic Overview

The image below is overview of project UML Use Case Diagram, for visualize the entire Use Case Diagram for Microsoft Visio [click here](https://github.com/viniciusmorgado/FastFoodRestaurant/raw/master/Assets/Uml/UML-UseCaseDiagrams.vsdx)

<strong>You can also see other diagrams used for design this object-oriented system:</strong>

<strong>[Class diagram](https://github.com/viniciusmorgado/FastFoodRestaurant/raw/master/Assets/Uml/UML-ClassDiagrams.vsdx)</strong> - A static structure diagram that describes the structure of the system by showing the system's classes, their attributes, operations, and the relationships among objects.

<strong>[Sequence Diagrams](https://github.com/viniciusmorgado/FastFoodRestaurant/raw/master/Assets/Uml/UML-SequenceDiagram.vsdx)</strong> - A sequence diagram shows, as parallel vertical lines (lifelines), different processes or objects that live simultaneously, and, as horizontal arrows, the messages exchanged between them, in the order in which they occur.

<strong>[Activity Diagrams](https://github.com/viniciusmorgado/FastFoodRestaurant/raw/master/Assets/Uml/UML-ActivityDiagrams.vsdx)</strong> - A graphical representation of workflow of stepwise activities and actions with support for choice, iteration and concurrency.

<strong>[Statechart Diagrams](https://github.com/viniciusmorgado/FastFoodRestaurant/raw/master/Assets/Uml/UML-StateMachineDiagrams.vsdx)</strong> - Is a diagram for modeling the dynamic nature of the system. They define different states of an object during its lifetime and these changes of state in response of events.

You can find the diagrams files at project directory <strong> [Assets/Uml](https://github.com/viniciusmorgado/FastFoodRestaurant/tree/master/Assets/Uml) </strong>

![Use case diagram overview](https://github.com/viniciusmorgado/FastFoodRestaurant/blob/master/src/Assets/Diagrams/UML-UseCaseDiagrams.png)

## UX | UI

<strong>Wireframe:</strong>

![interface wireframe](https://github.com/viniciusmorgado/FastFoodRestaurant/blob/master/src/Assets/Design/WireFrames/MainWindow%201920%20%E2%80%93%201.png)

<strong>Mockup:</strong>

![interface mockup](https://github.com/viniciusmorgado/FastFoodRestaurant/blob/master/src/Assets/Design/Mockups/Mockup%201920%20%E2%80%93%201.png)

Download UX research docs, [click here]().

# Running tests #

This project have a separate project for unit testing with xUnit, follow the AAA pattern for write the tests and keep all test code inside a test directory.

### Coding Style for tests

This project follow the pattern AAA (Arrange-Act-Assert) for write unit tests, it test method have three sections: arrange, act and assert. Each one of them only responsible for the part in which they are named after.

It is strongly recommended to use #region-#endregion for separation of stages.

Example:

First we have the arrange, here only have code required to setup that specific test, like objects, mocks setup and potentially expectations would be set.

```
#region Arrange

var repository = Substitute.For<IClientRepository>();
var client = new Client(repository);

#endregion

```
Then there is the Act, which should be the invocation of the method being tested. 

```
#region Act

client.Save();

#endregion
```
And on Assert you would simply check whether the expectations were met
```
#region Assert

mock.Received.SomeMethod();

#endregion
```
Example from Medium post by Paulo Gomes, [check here](https://medium.com/@pjbgf/title-testing-code-ocd-and-the-aaa-pattern-df453975ab80).

## Deployment

This software is a single form application for desktop clients, is not required any aditional changes for deployment, inside a project root:

```
dotnet publish
```

## Built With

### Design UI
* [Adobe XD](https://www.adobe.com/products/xd.html) - UI/UX design and collaboration tool from Adobe.

### Front-end:
* [Windows Forms Core](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-5.0) - UI framework that creates rich desktop client apps for Windows.

### Back-end:
* [.NET Core with C#](https://dotnet.microsoft.com/) - Open source, cross-platform Microsoft Framework.

### Database:
* [Microsoft SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) - Microsoft complete solution for relational databases.
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/) - Entity Framework Core is a modern object-database mapper for dotNET Core.

### Test:
* [xUnit.net](https://xunit.net/) - xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework.

## Developer(s)

<a href="https://github.com/viniciusmorgado" target="_blank">**Morgado**</a><br><br>
[![Morgado](https://avatars1.githubusercontent.com/u/34577818?s=250&u=3359746566aae46aafc4b9369a9f1e554b05a52a&v=4)](https://github.com/viniciusmorgado)<br><br>
<a href="https://github.com/viniciusmorgado" target="_blank">`github.com/viniciusmorgado`</a><br>

## License

- This project source code that which included all the parts written in C# by the author of this Github account is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

- **[MIT license - OpenSource dot org](http://opensource.org/licenses/mit-license.php)**  -  [![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- <strong>Proprietary Library and Frameworks:</strong> Some frameworks and librarys may be protected by proprietary licenses, please check "Proprietary Code and Trademarks" before use.
- <strong>Copyright Trademarks:</strong> Some logos and images may be protected by copyright,  please check "Proprietary Code and Trademarks" before use.

## Proprietary Code and Trademarks

- The logo of this project is inspired by [Jollibee](https://www.jollibee.com.ph/), do not use the same commercially.

- Picho icons of icons8 is authorized for personal or commercial purposes on the condition that you include a link to Icons8 in your work, please check [this link](https://icons8.crisp.help/en/article/can-i-use-icons8-services-for-free-1uvun5d/) before use.

## Acknowledgments

* [C# UI Academy - Learn How to Design Interactive Interfaces of Desktop Application](https://csharpui.com/)
