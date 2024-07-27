using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecomposeAbility : Ability
{
    public Animator animator;
    public override void Activate()
    {
        animator.SetBool("Decomposed", true);
    }
    public override void Deactivate()
    {
        animator.SetBool("Decomposed", false);
    }
    public DecomposeAbility() : base()
    {
        this.abilityName = "Decompose";
    }
}
