# Monday
## Advanced Unit Testing Pt. 2

### Keywords:
- `[TestFixture]`
  - Place above extra test classes
- `[SetUp]`
  - Runs before each test separately
- `[OneTimeSetUp]`
  - Runs once before all the tests begin
- `[TearDown]`
  - Runs after each test separately
- `[OneTimeTearDown]`
  - Runs once after all the tests finish
- `[Category("")]`
  - Set category "traits" for each test
  - Manual organisation
- `[Ignore("")]`
  - Set to ignore tests, with given reason
- `[TestCaseSource("")]`
  - Similar to TestCase
  - Object array storing parameters instead
  - Can use same inputs for multiple tests
  - Takes the name of the object array as a string
  - `public static object[] parameters` : `[TestCaseSource("parameters")]`
- **FIRST**
  - **F**ast
  - **I**solated
  - **R**epeatable
  - **S**elf-checking
  - **T**horough
- TDD
  - Test Driven Development
  - Write Tests, Run Tests, Tests Fail, Write Bare Minimum to Pass, Refactor
- NUnit
  - Framework is the adapter for Visual Studio, Core is the software itself

# Tuesday