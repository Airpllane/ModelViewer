using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public List<Model> modelList;

    private void Start()
    {
        modelList[0].RenderModel();
    }
}