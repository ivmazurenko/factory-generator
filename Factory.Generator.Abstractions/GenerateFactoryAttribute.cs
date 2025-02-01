using System;

namespace Factory.Generator.Abstractions;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateFactoryAttribute : Attribute;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateFactoryAttribute<T> : Attribute;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateFactoryAttribute<T1, T2> : Attribute;