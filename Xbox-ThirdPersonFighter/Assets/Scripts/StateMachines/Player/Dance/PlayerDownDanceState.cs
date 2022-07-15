using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDownDanceState : PlayerBaseState
{
    private readonly int DanceDownHash = Animator.StringToHash("DanceDown");
    private const float CrossFadeDuration = 0.1f;

    public PlayerDownDanceState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(DanceDownHash, CrossFadeDuration);
    }

    public override void Tick(float deltaTime)
    {
      ReturnToFreeLook();  
    }

    public override void Exit()
    {
        
    }

}
