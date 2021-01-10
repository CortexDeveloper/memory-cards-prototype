namespace Code.Runtime.Infrastructure.Services.SaveLoadService
{
  public interface ISaveLoadService<TData>
  {
    TData Load();
    void Save(TData data);
  }
}