# ProductMicroservice
How to build a simple project with Microservice and write unit test by xUnit and Fluent API.

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

[<img src="https://i.ibb.co/FDxfL5j/report-code-coverage.png" alt="report-code-coverage" border="0"/>]
