AntShares Unit Tests
====================

This project is a work in progress, aiming to provide unit test coverage for the core AntShares code.

Please note that we are aware that we are not using proper isolation / dependency injection / mocking techniques in these tests. To do that would require larger reworks of the base code which is a change for a later date in discussion with the core team, at the moment we are just aiming to get some basic coverage going.

Structure
====================

We use built in Visual Studio functionality with MSTest and the Microsoft.VisualStudio.TestPlatform.TestFramework package. 

To run the tests, build the solution to discover tests, then view and run the tests from the 'Test Explorer' window within Visual Studio.

Coverage
====================

/Core
	AccountState.cs
