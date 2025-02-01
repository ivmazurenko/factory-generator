using Factory.Generator.Abstractions;
using Xunit;

namespace Factory.Generator.Tests;

public class FactoryTests
{
    [Fact]
    public void GeneratesFactoryWithExpectedSignatureFor2CtorDependency()
    {
        // todo
    }
}

[GenerateFactory<int, ParameterDependency>]
[GenerateFactory<ParameterDependency>]
[GenerateFactory]
public class Service
{
    public Service(int parameterDependency1, ParameterDependency parameterDependency2, CtorDependency ctorDependency)
    {
    }
}

public class ParameterDependency;

public class CtorDependency;