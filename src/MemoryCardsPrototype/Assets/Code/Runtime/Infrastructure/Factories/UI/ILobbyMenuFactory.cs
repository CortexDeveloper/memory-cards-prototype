﻿using UnityEngine;

namespace Infrastructure.Factories.UI
{
  public interface ILobbyMenuFactory
  {
    void Load();
    GameObject Create(Vector3 at, Quaternion rotation, Transform parent);
  }
}