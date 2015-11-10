# csharlibformagexmlrpcapi
Automatically exported from code.google.com/p/csharlibformagexmlrpcapi

.NET C# Object Library for Magento's XML-RPC API
We built a connector for our Magento Targeted Email Marketing Extension. While building this connector we noticed a significant lack of information about how to work with the Magento API on the .NET platform.

Our first choice was to use the SOAP API because Visual Studio has wonderful support for SOAP. However, after jumping through many hoops, the best we could do was add the Web Reference but after that it was unusable. Apparently the SOAP API is not totally compliant with all the standards VS was hoping for. To go any further would have required hacking the core files and that was not an option for us to do as we could not possibly require all our clients start hacking their core files.

EDIT As of v1.3 there is a second WSDL that reportedly has support for vs 2008. Call it like so: http://<host>/<magento>/api/v2_soap?wsdl

We then turned to the XML-RPC API and were able to start building out our object library. We found that the documentation for the API was very poor and often wrong at times wrt to the type of values it was returning. Almost everything goes in and out as strings which still baffles us. The filter parameters that get passed in are not documented anywhere that we could find so we pretty much just took educated guesses to find what we could. Eventually we saw patterns in the inconsistencies, which were, at least, consistently inconsistent.

Even though we really only needed to read the orders object, we went a head and built out the full object library with samples to every object and method. We're making it publicly available here under the MIT X11 license. We've used Charles Cook's XML-RPC.NET libary which is also published under the MIT X11 license.

We did need to modify Cook's library as the Magento XML-RPC API uses extensions for null values. These values come back as <nil /> and will throw a nullreference exception. We found two ways to handle this. First is to search/replace the xml as it comes back. The other is to catch the null reference exception when working with the properties. In our testing the search/replace method was much more efficient but YMMV.

The source for our object library and samples is published here along with the source for Cook's XML-RPC.NET library that includes both hacks for the NULL values.

NOTES :

If you are receiving the error about calling parameters not matching signature then your problem is most likely eAccelerator. We found that after disabling eAccelerator or adding a filter for the url "Api/*.php" the error goes away. Apparently eAcclerator is causing a parameter validation exception to be thrown. If eAccelerator has the API cached then the login call with throw error. Otherwise you will be able to login but the second call with throw exception. Subsequent calls will throw exceptions until eAcclerator releases it's cache.

If you are receving a "Not Found" error and you have multiple stores then you may need to pass the store id like this: http://www.mymagentostore/storedirectory/<storeid>/api/xmlrpc
