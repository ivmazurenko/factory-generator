namespace Factory.Generator.Abstractions;

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