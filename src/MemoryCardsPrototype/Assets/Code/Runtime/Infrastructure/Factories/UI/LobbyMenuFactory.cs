﻿using UnityEngine;
using Zenject;

namespace Infrastructure.Factories.UI
{
  public class LobbyMenuFactory : ILobbyMenuFactory
  {
    public LobbyMenuFactory(DiContainer diContainer) =>
      _diContainer = diContainer;

    private readonly DiContainer _diContainer;

    private Object _menuPrefab;

    public void Load() =>
      _menuPrefab = Resources.Load(UIPrefabsPaths.LobbyMenu);

    public GameObject Create(Vector3 at, Quaternion rotation, Transform parent) =>
      _diContainer.InstantiatePrefab(_menuPrefab, at, rotation, parent);
  }
}