using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRightDanceState : PlayerBaseState
{
    private readonly int DanceRightHash = Animator.StringToHash("DanceRight");
    private const float CrossFadeDuration = 0.1f;

    public PlayerRightDanceState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(DanceRightHash, CrossFadeDuration);
    }

    public override void Tick(float deltaTime)
    {
        ReturnToFreeLook();
    }

    public override void Exit()
    {
        
    }

}
