using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_PlayerDetectedState : PlayerDetectedState
{
    private Enemy1 enemy;
    public E1_PlayerDetectedState(Entity entity, FiniteStateMachine stateMachine, string animBoolName, D_PlayerDetectedState stateData, Enemy1 enemy) : base(entity, stateMachine, animBoolName, stateData)
    {
        this.enemy = enemy;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (performCloseAction)
        {
            stateMachine.ChangeState(enemy.meleeAttackState);
        }
        else if (performLongAction)
        {
            stateMachine.ChangeState(enemy.chargeState);
        }
        else if (!isPlayerMaxRange)
        {
            stateMachine.ChangeState(enemy.lookPlayerState);
        }
  
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
