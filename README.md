# NOTE: This is a FORK
The original project is located https://github.com/QuickPay/quickpay-dotnet-client  
This fork is to implement some QoL for specific usage, such as overriding the base url of the Quickpay API.    
This is done to allow for easier testing in local setups, by implementing a Mock Quickpay service.    
The code might start to differ more depending on how the original project evolves versus our specific requirements/needs.  


***********************
# Original Readme:
***********************
# quickpay-dotnet-client
`quickpay-dotnet-client` is a official client for [QuickPay API](http://tech.quickpay.net/api). The Quickpay API enables you to accept payments in a secure and reliable manner.  
This assembly currently support QuickPay `v10` api.

## Installation
You can either download the source directly from the GitHub repo, or install the nuget package which can be found on [nuget.org](https://www.nuget.org/packages/QuickPay.API.Client).

## Usage

Before doing anything you should register yourself with QuickPay and get access credentials.
If you haven't please [click](https://quickpay.net/) here to apply.

### Services

The communication with the QuickPay API is done by services that each represent a specific area of the API. At the moment we support 5 services.
 - AccountService
 - AcquirersService
 - PaymentsService
 - SubscriptionsService
 - PingService

 Each service must be initialised with a valid API Key for them to work.

### Models

The requests and responses that are supported by the services also comes with model classes, so parsing of the http response is done for you.


### Extension

If you need access to other endpoints than what is available in the current version, please feel free to suggest them in [GitHub](https://github.com/QuickPay/quickpay-dotnet-client).

You can also take matters into your own hand and implement the missing parts yourself. To do this you can create your own service class and let it extend the `QuickPayRestClient`, which will ensure that the correct header values are added to the requests. You can look at the current services in the source to get an example on how to use the `QuickPayRestClient`.

### Permissions

API Keys at QuickPay has custom permissions for each endpoint in the API. Please ensure that the API Key you use has the required permissions for your use case, else you can spend a lot of time debugging for no reason.

### Example

In the GitHub repo you can take a look at the [example project](https://github.com/QuickPay/quickpay-dotnet-client/blob/documentationUpdate/QuickPay.Example/PaymentExample.cs). It shows what you need to do in order to create a payment, generate a payment link to show for the user in a browser and how to capture the payment.


#### The unit tests

To run the tests you need to set a valid API Key as an environment variable. Please see `QpConfig.cs` for more info.
