# ProductMicroservice
How to build a simple project with Microservice and write unit test by xUnit and Fluent API.

## Running unit test and watching code coverage

You need to some require external nuget packages. Install [Converlet](https://www.nuget.org/packages/coverlet.msbuild/) and [FluentAssertions](https://www.nuget.org/packages/FluentAssertions/) for your project using the following cli commands.
```

- dotnet add package coverlet.msbuild --version 2.0.1
- dotnet add package FluentAssertions --version 5.0.0
```

To get converlet to collect code coverage for your codebase, we need just to run the following command at the repository root.

```
dotnet test ProductMicroservice.UnitTests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover\" /p:CoverletOutput=BuildReports\Coverage\
```

The result will be collected in a coverage.coverlet.xml file in the ProductMicroservice.UnitTests directory.


Test Run Successful.
Test execution time: 5.3307 Seconds

Calculating coverage result...
  Generating report 'BuildReports\Coverage\.opencover.xml'

+---------------------+--------+--------+--------+
| Module              | Line   | Branch | Method |
+---------------------+--------+--------+--------+
| ProductMicroservice | 1.2%   | 0%     | 2.9%   |
+---------------------+--------+--------+--------+

+---------+--------+--------+--------+
|         | Line   | Branch | Method |
+---------+--------+--------+--------+
| Average | 1.2%   | 0%     | 2.9%   |
+---------+--------+--------+--------+