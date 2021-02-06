namespace Code.Runtime.Infrastructure.Services.SaveLoadService
{
  public interface ISaveLoadService<TData>
  {
    TData LoadedData { get; }

    TData Load(); //TODO todo
    void Save(TData data);
  }
}