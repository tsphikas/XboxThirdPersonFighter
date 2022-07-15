using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    public bool IsAttacking{get; private set;}
    public Vector2 MovementValue{get; private set;}

    public event Action JumpEvent;

    public event Action DodgeEvent;

    public event Action TargetEvent;

    public event Action CancelEvent;


    /* Dance Actions for Marco & Rico */
    public event Action DanceUpEvent;
    public event Action DanceDownEvent;
    public event Action DanceLeftEvent;
    public event Action DanceRightEvent;

    private Controls controls;

    private void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);

        controls.Player.Enable();    
    }

    private void OnDestroy()
    {
        controls.Player.Disable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(!context.performed){return;}
        JumpEvent?.Invoke();
    }

    public void OnDodge(InputAction.CallbackContext context)
    {
        if(!context.performed){return;}
        DodgeEvent?.Invoke();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        MovementValue = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        
    }

    public void OnTarget(InputAction.CallbackContext context)
    {
        if (!context.performed){return;}

        TargetEvent?.Invoke();
    
    }

    public void OnCancel(InputAction.CallbackContext context)
    {
        if (!context.performed){return;}

        CancelEvent?.Invoke();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            IsAttacking = true;
        }
        else if (context.canceled)
        {
            IsAttacking = false;
        }

    }


    /* Dance Moves For Marco & Rico */
 

    public void OnDanceUpDPad(InputAction.CallbackContext context)
    {
        if(!context.performed){return;}
        DanceUpEvent?.Invoke();
    }

    public void OnDanceDownDPad(InputAction.CallbackContext context)
    {
        if(!context.performed){return;}
        DanceDownEvent?.Invoke();
    }

    public void OnDanceLeftDPad(InputAction.CallbackContext context)
    {
        if(!context.performed){return;}
        DanceLeftEvent?.Invoke();
    }

    public void OnDanceRightDPad(InputAction.CallbackContext context)
    {
        if(!context.performed){return;}
        DanceRightEvent?.Invoke();
    }
}

