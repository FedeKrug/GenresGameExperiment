using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public bool canSeePlayer;
    public State chaseState;

    Animator anim;
    private void Awake()
    {
        anim = GetComponentInParent<Animator>();
    }
    public override State RunCurrentState()
    {
        if (canSeePlayer)
        {
            anim.SetBool("FoundPlayer", true);
            return chaseState;
        }
        else if (!canSeePlayer)
        {
            return this;
        }
        else {
            anim.SetBool("FoundPlayer", false);
            return this;
        }
    }


}
