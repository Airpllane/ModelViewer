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

    public ModelPrefab instantiatedPrefab;

    public ModelPrefab RenderModelAt(Transform transform)
    {
        instantiatedPrefab = Instantiate(modelPrefab, transform);
        foreach(Ability ability in modelAbilities)
        {
            ability.modelPrefab = instantiatedPrefab;
        }
        return instantiatedPrefab;
    }

    public void UnrenderModel()
    {
        if (instantiatedPrefab) Destroy(instantiatedPrefab.gameObject);
    }
}