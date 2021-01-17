using Code.Runtime.CardGame.Data;
using UnityEngine;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers.ScriptableObjects
{
  [CreateAssetMenu(fileName = nameof(CardGameConfigurationInstaller), menuName = "CardGame/ScriptableObjectInstallers/" + nameof(CardGameConfigurationInstaller))]
  public class CardGameConfigurationInstaller : ScriptableObjectInstaller
  {
    [SerializeField] private ScriptableObject Configuration;
    
    public override void InstallBindings()
    {
      Container
        .Bind<ICardGameConfiguration>()
        .FromInstance(Configuration as ICardGameConfiguration);
    }
  }
}