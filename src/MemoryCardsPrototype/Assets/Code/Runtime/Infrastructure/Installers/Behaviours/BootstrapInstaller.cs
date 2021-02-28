using Infrastructure.EntryPoint;
using Infrastructure.Services.AudioPlayer;
using Infrastructure.Services.CoroutinesRunner;
using Infrastructure.Services.SaveLoadService;
using Infrastructure.Services.ScenesLoader;
using Infrastructure.StateMachine;
using Infrastructure.StateMachine.States;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers.Behaviours
{
  public class BootstrapInstaller : MonoInstaller
  {
    [SerializeField] private GameObject _coroutineRunner;
    [SerializeField] private GameObject _audioPlayer;
    
    public override void InstallBindings()
    {
      BindCoroutineRunner();
      BindScenesLoader();
      BindSaveLoadService();
      BindAudioPlayer();
      BindGameStateMachine();
      BindGameInstance();
    }

    private void BindGameInstance()
    {
      Container
        .Bind<IGame>()
        .To<Game>()
        .AsSingle()
        .NonLazy();
    }

    private void BindScenesLoader()
    {
      Container
        .Bind<ISceneLoader>()
        .To<ScenesLoader>()
        .AsSingle();
    }

    private void BindCoroutineRunner()
    {
      Container
        .Bind<ICoroutinesRunner>()
        .FromComponentInNewPrefab(_coroutineRunner)
        .AsSingle();
    }

    private void BindSaveLoadService()
    {
      Container
        .Bind<ISaveLoadService<UserSettingsData>>()
        .To<UserSettingsStorage>()
        .AsSingle();
    }

    private void BindAudioPlayer()
    {
      Container
        .Bind<IAudioPlayer>()
        .FromComponentInNewPrefab(_audioPlayer)
        .AsSingle();
    }
    
    private void BindGameStateMachine()
    {
      Container
        .Bind<BootstrapState>()
        .To<BootstrapState>()
        .AsSingle();
      
      Container
        .Bind<LobbyState>()
        .To<LobbyState>()
        .AsSingle();

      Container
        .Bind<SessionState>()
        .To<SessionState>()
        .AsSingle();
      
      Container
        .Bind<IGameStateMachine>()
        .To<GameStateMachine>()
        .AsSingle();
    }
  }
}