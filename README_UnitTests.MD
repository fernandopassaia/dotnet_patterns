### Hi There. Document for Unit Tests

**Principle of Technique Red-Green Refactory**:
(1) First of All I'll write dowm ow my test-names with "Assert.Fail()". I'll made all my tests fail. Then, So for example: If i have 12 tests, I'll have 12 fails.
(2) Then I'll go to Green, make this tests PASS with minimal work as possible. It will be a mass, because I'll replicate code of one in another one...
(3) Then I'll refactor the code, making the code easy to maintanence.

**Principle of Fail-Fast Validations**:
When I start a validation, before go to bank, check stock, check client and other operations that will need I/O (bank actions): I need to do things that will fail fast, like check the COMMANDS, if commands is invalid, I'll send back messages (validations) to API and stop the operation, avoiding go to and hit database and other operations. I've already did it - always, but cool to know it has a name.

**MochaTs**:
A tool used to test the API itself. It's a Typescript library that allow you to call the API and test the endpoints.

**Note**:
I wrote a BAD Application inside the folder UnitTests. Then I compromisse myself to rewrite it using DDD, SOLID and all unit-testing techniquies. On a Second folder I've rewrite the entire APP and the Whole Tests for it.

### Starting EduardoPires Testing Course (5 Hours):

**Note**: Lots of informations about this course is inside "UnitTests > EduardoPires > Doc" folder in prints.

Used Framework for Course: **xUnit**.
Install-Package xunit
Install-Package xunit.runner.visualstudio

Framework of Mock: **Moq**
Install-Package Moq

Both xUnit and Moq are the OFICIAL test-packages used in .NetCore and Asp.Net Core Tests from Microsoft.

**FakeData Sane Generator (generate test-data really near to reality)**:
Install-Package Bogus
https://github.com/bchavez/Bogus
