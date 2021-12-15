# Chapter 11 - Exercise 1
##  Objectives
- Learn how to write integration tests with Playwright

## Goal 
This exercise tests if our implementation works from front-to-back.

## Exercise
### Getting Started
- Clone [the repository of Chapter 10](https://github.com/HOGENT-Web/csharp-ch-10-exercise-1/tree/solution)
- Switch to the `solution` branch
- Make sure to fill in the Auth0 Credentials in the Client and Server project or disable Auth using the `FakeAuthProvider`

### Setup
- Add a new solution folder called `tests`, make sure it's reflected in the folder hierarchy.
- Add a new nUnit project to the solution in the tests folder called `IntegrationTests`.
- Add the nUnit Playwright package to the `IntegrationTests` project.
- Build the test project using a dotnet command or visual studio
- Install the required browsers using the `playwright install` command.

### Testing the Index page
- Create a new nUnit test class called `ProductIndexTests.cs`
- Make it inherit from the `PageTest` provided by the Playwrite nUnit package.
- Create the following tests:
    - On the initial load, there are 25 products.
    - When using a filter `Gloves`, the correct amount of items in returned.
    - When setting a price higher then 50 and lower then 100, the correct result is returned.

### Testing the Detail page
- Create a new nUnit test class called `ProductDetailTests.cs`
- Make it inherit from the `PageTest` provided by the Playwrite nUnit package.
- Create the following tests:
    - On the initial load, a product with a name is displayed.

### Extra: Testing Mutations
- After logging in as administrator 
    - Create a function which logs in as an administrator and use it
    - Shows the delete button
    - When deleting the confirm delete is shown
    - when clicking confirm delete the product is deleted and we're navigated back to the index page

## Solution
A possible solution can be found [here](https://github.com/HOGENT-Web/csharp-ch-11-exercise-1/tree/solution#solution).
