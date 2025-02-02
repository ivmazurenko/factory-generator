using System;

namespace FactoryGenerator.Abstractions;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateIFactoryAttribute : Attribute;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateIFactoryAttribute<T> : Attribute;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateIFactoryAttribute<T1, T2> : Attribute;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateIFactoryAttribute<T1, T2, T3> : Attribute;