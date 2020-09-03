# Calculator
Lab Exercise: "Unit-testing class Calculator" - Exercise 01.1 - 01.4 (Mandatory) + 01.5 (Optional)

# Exercise 1: Get ready!
1. Create a solution for this exercise.
2. Copy the application project (not the test project) from Exercise 1 to the new solution folder and include the
application project in the solution.
3. Add another C# class library project (:Net Core) to the solution. Name this project Calculator.Test.Unit. In
this project, add a reference to the application project. Install NUnit for this project using the NuGet
Manager.
4. – alternatively add an NUnit Test (.Net Core) project using the template. This will automatically install NUnit
and other NuGet packages.
At this time, you should have 1 C# solution containing and 2 C# class library projects, one named Calculator (this is
the application project) and one named Calculator.Test.Unit (this is the test project).

# Exercise 2: Define your test fixture
Add a new C# source file to the test project (that’s Calculator.Test.Unit). In this file, define the class
CalculatorUnitTests. This class is your test fixture and will hold all your unit tests for class Calculator.

# Exercise 3: Implement your tests
Implement your unit tests in the file you added to the test project above – test the class Calculator as thoroughly as
you can using NUnit tests. Is it difficult?

# Exercise 4: Compare and contrast
Compare your tests in the two lab exercises and reflect on hand-testing vs. unit testing with a framework:
Extensibility Which form of test is easiest to extend, e.g. if new functionality is required for class Calculator?
Maintainability Which form of test is easiest to maintain?
Readability Imagine you are new to the project. Which form of test is easiest to read?
Automation Which type of test is easiest to automate? If you wanted to collect and compare test results every 15
minutes, which kind of test is it easiest to see if passed or failed?

# Exercise 5 (optional): Investigate the [TestCase] attribute
NUnit offers a number of facilities for the definition of repetitious test cases. For example, you may have perhaps 6
individual tests of the method Power(), one for each combination of positive, negative, and 0 value of the two
arguments. Each of these methods are tagged with the property [Test]. 
Document name
Date/rev
Page 2 of 2
While this works just fine, it gets kind of tedious to duplicate the test code six times, only varying the arguments.
Instead, you can use the [TestCase] attribute to specify arguments for the individual tests. Investigate this and
refactor your test suite to use [TestCase] instead of [Test].
