using Factory.Generator.Examples;

var service3Dependency = new Int32Dependency1Service3DependencyFactory(new Dependency2())
    .Create(1, new Dependency1());

var service0Dependency = new Service0DependencyFactory().Create();

Console.WriteLine(service0Dependency);
Console.WriteLine(service3Dependency);