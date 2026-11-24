using Godot;
using System;

public interface IState<TContext> {
    void Enter();
    void Exit();
    void Update(double delta);
    void PhysicsUpdate(double delta);

}

public class StateMachineComponent<TContext, TStateId> {

}
