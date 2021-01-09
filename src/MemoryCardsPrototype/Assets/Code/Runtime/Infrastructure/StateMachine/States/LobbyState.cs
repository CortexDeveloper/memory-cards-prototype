﻿namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class LobbyState : IState
  {
    public LobbyState(IStateMachine stateMachine) => 
      StateMachine = stateMachine;

    public IStateMachine StateMachine { get; }

    public void Enter()
    {
      
    }

    public void Exit()
    {
      
    }
  }
}