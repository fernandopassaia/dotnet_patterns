### Hi There. Document for Unit Tests

**Principle of Technique Red-Green Refactory**:
(1) First of All I'll write dowm ow my test-names with "Assert.Fail()". I'll made all my tests fail. Then, So for example: If i have 12 tests, I'll have 12 fails.
(2) Then I'll go to Green, make this tests PASS with minimal work as possible. It will be a mass, because I'll replicate code of one in another one...
(3) Then I'll refactor the code, making the code easy to maintanence.

**Principle of Fail-Fast Validations**:
When I start a validation, before go to bank, check stock, check client and other operations that will need I/O (bank actions): I need to do things that will fail fast, like check the COMMANDS, if commands is invalid, I'll send back messages (validations) to API and stop the operation, avoiding go to and hit database and other operations. I've already did it - always, but cool to know it has a name.

