using FactoryGenerator.Abstractions;

namespace Factory.Generator.Examples;

[GenerateIFactory]
public class Service0Dependency;

[GenerateIFactory<int, Dependency1, Dependency2>]
[GenerateIFactory<int, Dependency1>]
[GenerateIFactory<Dependency1>]
[GenerateIFactory]
public class Service3Dependency
{
    public Service3Dependency(int _, Dependency1 __, Dependency2 ___)
    {
    }
}

public class Dependency1;

public class Dependency2;