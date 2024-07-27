using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Model : ScriptableObject
{
    public string modelName;
    public string modelDescription;

    public ModelPrefab modelTemplate;
}