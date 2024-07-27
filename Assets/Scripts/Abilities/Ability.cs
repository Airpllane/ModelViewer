using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public ModelPrefab modelPrefab;
    public string abilityName;
    public abstract void Activate();
    public abstract void Deactivate();
}