using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeftDanceState : PlayerBaseState
{
    private readonly int DanceLeftHash = Animator.StringToHash("DanceLeft");
    private const float CrossFadeDuration = 0.1f;

    public PlayerLeftDanceState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(DanceLeftHash, CrossFadeDuration);
    }

    public override void Tick(float deltaTime)
    {
        ReturnToFreeLook();
    }

    public override void Exit()
    {
        
    }

}
