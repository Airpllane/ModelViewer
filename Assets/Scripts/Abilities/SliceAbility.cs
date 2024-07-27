using UnityEngine;

public class SliceAbility : Ability
{
    public override void Activate()
    {
        modelPrefab.Slice();
    }
    public override void Deactivate()
    {
        modelPrefab.Unslice();
    }
    public SliceAbility() : base()
    {
        this.abilityName = "Slice";
    }
}