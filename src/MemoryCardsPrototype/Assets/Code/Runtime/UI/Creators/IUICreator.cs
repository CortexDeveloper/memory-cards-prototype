namespace UI.Creators
{
  public interface IUICreator<TUIType>
  {
    void CreateUI(TUIType uiType);
  }
}