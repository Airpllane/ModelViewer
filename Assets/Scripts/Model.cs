using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Model : ScriptableObject
{
    public string modelName;
    public string modelDescription;
    public List<Ability> modelAbilities;

    public List<GameObject> overlay;
    public List<GameObject> underlay;

    public void RenderModel()
    {
        foreach (GameObject component in underlay)
        {
            Instantiate(component);
        }


    }
}

public class Ability : ScriptableObject
{
    public Animation animation;
}
