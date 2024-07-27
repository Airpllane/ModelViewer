using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public string abilityName;
    public abstract void Activate();
    public abstract void Deactivate();
}