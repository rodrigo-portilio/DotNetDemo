namespace DotNetDemo.Domain.Interfaces;

public interface IUnityOfWork
{
    Task<bool> Commit();
}