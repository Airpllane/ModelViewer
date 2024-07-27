using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecomposeAbility : Ability
{
    public override void Activate()
    {
        modelPrefab.Decompose();
    }
    public override void Deactivate()
    {
        modelPrefab.Recompose();
    }
    public DecomposeAbility() : base()
    {
        this.abilityName = "Decompose";
    }
}
