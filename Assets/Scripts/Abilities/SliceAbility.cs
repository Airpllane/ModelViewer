using System.Collections.Generic;
using UnityEngine;

public class SliceAbility : Ability
{
    public List<GameObject> overlayComponents;
    public override void Activate()
    {
        foreach (GameObject overlayComponent in overlayComponents)
        {
            overlayComponent.SetActive(false);
        }
    }
    public override void Deactivate()
    {
        foreach (GameObject overlayComponent in overlayComponents)
        {
            overlayComponent.SetActive(true);
        }
    }
    public SliceAbility() : base()
    {
        this.abilityName = "Slice";
    }
}