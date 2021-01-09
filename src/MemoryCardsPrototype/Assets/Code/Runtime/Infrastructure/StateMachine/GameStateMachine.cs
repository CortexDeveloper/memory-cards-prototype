using System.Collections.Generic;
using Code.Runtime.Infrastructure.StateMachine.States;

namespace Code.Runtime.Infrastructure.StateMachine
{
  public class GameStateMachine : IStateMachine
  {
    public GameStateMachine(Dictionary<GameStates, IState> states)
    {
      _states = states;
    }

    public IState CurrentState { get; private set; } 

    private readonly Dictionary<GameStates, IState> _states;
    
    public void ChangeState(GameStates state)
    {
      CurrentState?.Exit();
      CurrentState = _states[state];
      CurrentState?.Enter();
    }
  }
}