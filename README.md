# RimuutWebUI and APITest
It is a project that calculates the Invoice Amount and checks whether the page responds to requests. 
## Proje Özellikleri
* Xunit Architecture is used.
* Written in C# 6.0.net core language.
* RestSharp library is integrated for endpoint control.
* Selenium Web Driver, ChromeWebDriver Libraries are used for regression web automation.
* UI Smoke test and API control are performed via Chrome browser.
* Url: "https://rimuut.com/pricing"
* Selenium Web driver and ChromeWebDriver libraries are used.
* Xunit library is used for Assertion.
* It is established with an improved Class structure.

## Task Request(API)
1. Url: "https://rimuut.com/pricing" 
2. It goes to the URL, calls the get method, checks with assert whether it has arrived or not, reports any errors, otherwise it says pass.

## Task Request(UI)
1. Opens the page. - "https://rimuut.com/pricing"
2. Enters the billing rate as "1000" to calculate the rate.
3. Changes the payment method to "virtual iban".
4. Converts the variable 1000 to string and compares it to the 951.00 (Current rate) that the end user will receive. If it is correct, it passes, if it is incorrect, it reports the error.
