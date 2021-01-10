namespace Code.Runtime.Infrastructure.Services.SaveLoadService
{
  public interface ISaveLoadService<TData>
  {
    TData LoadedData { get; }

    TData Load();
    void Save(TData data);
  }
}