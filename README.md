# ProductMicroservice
Building a ProductMicroservice project and intergate it with some new technologies.

- Integration of GraphQL in this project
- Running unit test and watching code coverage

## Integration of GraphQL in this project.

You need to install some require external packages for GraphQL as the following:

- [GraphQL](https://www.nuget.org/packages/GraphQL/2.4.0)
- [GraphQL.Server.Transports.AspNetCore](https://www.nuget.org/packages/GraphQL.Server.Transports.AspNetCore/3.4.0)
- [GraphQL.Server.Ui.Playground](https://www.nuget.org/packages/GraphQL.Server.Ui.Playground/3.4.0)

To getting started with GraphQL in ASP .NET Core, visit the [GraphQL ASP.NET Core Tutorial](https://code-maze.com/graphql-asp-net-core-tutorial/)

To test our GraphQL API, we are going to use the GraphQL.UI.Playground tool. So, let's first start our server application and then navigate to the http://localhost:60809/ui/playground address.

<img src="https://i.ibb.co/hZFg5P2/graph-QL-testing.png" alt="Graph-QL-Product" border="0" />

Excellent, we see that everything is working just as it supposed to. As soon as we send our query with id, name, and price of products (which must match the query name we created in the AppQuery file), we get the required result.

## Running unit test and watching code coverage

You need to some require external nuget packages. Install [Converlet](https://www.nuget.org/packages/coverlet.msbuild/) and [FluentAssertions](https://www.nuget.org/packages/FluentAssertions/) for your project using the following cli commands.
```

- dotnet add package coverlet.msbuild --version 2.7.0
- dotnet add package FluentAssertions --version 5.0.0
```

To get converlet to collect code coverage for your codebase, we need just to run the following command at the repository root.

```
dotnet test ProductMicroservice.UnitTests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover\" /p:CoverletOutput=BuildReports\Coverage\
```

The result will be collected in a coverage.coverlet.xml file in the ProductMicroservice.UnitTests directory.

If you want to generate report, you can also install the following command.

```
- dotnet tool install -g dotnet-reportgenerator-globaltool
- dotnet test ProductMicroservice.UnitTests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover\" /p:CoverletOutput=BuildReports\Coverage\
- reportgenerator "-reports:BuildReports\Coverage\coverage.opencover.xml" "-targetdir:BuildReports\Coverage" -reporttypes:HTML;HTMLSummary
```

Once you run commands is completed then open index.html file in BuildReports\Coverage will display as image below.

<img src="https://i.ibb.co/tJmNTqW/report-code-coverage.png" alt="report-code-coverage" border="0"/>