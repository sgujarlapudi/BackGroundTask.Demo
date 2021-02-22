Running background tasks in an ASP.NET core application.
We use background services where we connect with cloud-managed services like streams and queues
which usually implemented throug continusly running methods.
Most of the managed cloud services as accessed via an HTTP connection, hence there are usually no callbacks

This application has 2 ways of implementing the running background tasks 
1. Creating a class which implements IHostedService refer to BackgroundPrinter.cs
2. Creating a class which is derived from Background service refer to DerivedBackgroundPrinter.cs

In both the cases we use the ConfigureServices in Startup class

The hosted background services implmentation is deeply integrated with the dependency injection of ASP.NET Core.


