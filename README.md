# Enhanced .NET Core Template(s) Boilerplate Code

The Enhanced Boilerplate Template(s) were inspired by a personal need to have 
preferred project architecture files for a particular template out of the box.
An immediate benefit to this approach is faster setup time for simple project
architectures (or even complex! :shipit:). Consumers require minimal refactor
effort to get started. 

#### 1.0 [.Net Core 5.0 MVC Template](dotnet-core-ef-repo-pattern-async/Readme.MD)

This is an enhancement to the .Net Core 5.0 MVC project template. Consumers get the
following setup out of the box: 

* Customized Database Context (MS Sql) with fluent configuration
* Customized .NET identity database context
* Repository pattern
* Logging setup (Serilog)
* Custom host configuration