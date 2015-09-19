# SeleniumShim20
SeleniumShim uses implicit retry until timeout loops within calls to FindElement and user actions on IWebElement objects which solves race conditions and problems with 'stale' references to WebElement.

If you have Thread.Sleep(n) anywhere in your Selenium test code, you need SeleniumShim!

Proposed changes for 2.1 release:

- Latency values
- TextIsVisible()
- Document use of wait times for performance testing
- Unit tests (internal)
- Source code samples and documentation

