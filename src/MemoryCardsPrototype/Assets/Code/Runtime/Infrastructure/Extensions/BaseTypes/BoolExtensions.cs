namespace Code.Runtime.Infrastructure.Extensions.BaseTypes
{
  public static class BoolExtensions
  {
    public static int AsInt(this bool value) => 
      value ? 1 : 0;
  }
}