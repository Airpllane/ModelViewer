using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Model : ScriptableObject
{
    public string modelName;
    public string modelDescription;
    public List<Ability> modelAbilities;

    public ModelPrefab modelPrefab;

    public void RenderModel()
    {
        Instantiate(modelPrefab).Slice();
    }
}

public interface Ability
{
    public void Activate(ModelPrefab modelPrefab);
    public void Deactivate(ModelPrefab modelPrefab);
}

public class SliceAbility : Ability
{
    public void Activate(ModelPrefab modelPrefab)
    {
        modelPrefab.Slice();
    }
    public void Deactivate(ModelPrefab modelPrefab)
    {
        modelPrefab.Unslice();
    }
}