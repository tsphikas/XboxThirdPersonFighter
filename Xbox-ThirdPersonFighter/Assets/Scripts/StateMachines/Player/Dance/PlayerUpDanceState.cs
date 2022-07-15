using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpDanceState : PlayerBaseState
{
    private readonly int DanceUpHash = Animator.StringToHash("DanceUp");
    private const float CrossFadeDuration = 0.1f;

    public PlayerUpDanceState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(DanceUpHash, CrossFadeDuration);
    }

    public override void Tick(float deltaTime)
    {
        ReturnToFreeLook();
    }

    public override void Exit()
    {
        
    }

}
