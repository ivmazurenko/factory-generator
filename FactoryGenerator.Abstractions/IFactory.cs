namespace FactoryGenerator.Abstractions;

public interface IFactory<TResult>
{
    TResult Create();
}

public interface IFactory<TParameter, TResult>
{
    TResult Create(TParameter parameter);
}

public interface IFactory<TParameter1, TParameter2, TResult>
{
    TResult Create(TParameter1 parameter1, TParameter2 parameter2);
}

public interface IFactory<TParameter1, TParameter2, TParameter3, TResult>
{
    TResult Create(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);
}