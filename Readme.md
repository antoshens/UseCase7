## Test Description

The *UseCase7* testing suite is primarily focused on two main classes: *StudentConverter* and *PlayerAnalyzer*.
The StudentConverter class is designed to convert student data, especially by marking specific attributes such as being exceptional or on the honor roll, based on their age and grade.
Its tests ensure that the conversion logic functions as expected.
The PlayerAnalyzer class, on the other hand, evaluates player data to calculate a score based on a player's age, experience, and skillset.
Through its tests, it is ensured that the score computation is accurate, catering to various edge cases and scenarios.

The tests have been categorized into Positive and Negative tests.
Positive tests confirm the expected behavior under normal or beneficial circumstances, while negative tests ensure robustness by checking behavior under unintended or harmful inputs.
Both of these categories are further reinforced by using the xUnit framework, leveraging features such as IClassFixture for test setup and IDisposable for cleanup, ensuring that each test runs in a fresh state.

## How to Run Tests Locally
**Prerequisites**:
Before you begin, ensure you have the following installed:

.NET SDK (Version recommended: .NET 6.0 or later)
A preferred code editor or IDE (e.g., Visual Studio, Visual Studio Code)

**Clone the Repository**:

``` bash
git clone https://github.com/antoshens/UseCase7
cd UseCase7
```
**Restore Dependencies**:
In your terminal or command prompt, navigate to the project directory and run:

``` bash
dotnet restore
```

**Running the Tests**:
Navigate to the test project directory (UseCase7.Tests) and execute the following command:

``` bash
dotnet test
```

**Review Results**:
After the tests have completed running, the results will be displayed in the terminal.
Look for any failures or errors and refer to the test logs for detailed information.

That's it! You've successfully run the tests locally.