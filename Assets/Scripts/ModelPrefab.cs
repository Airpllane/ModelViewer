using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPrefab : MonoBehaviour
{
    public List<GameObject> underlayComponents;
    public List<GameObject> overlayComponents;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Decompose()
    {
        animator.SetBool("Decomposed", true);
    }

    public void Recompose()
    {
        animator.SetBool("Decomposed", false);
    }

    public void Slice()
    {
        foreach(GameObject overlayComponent in overlayComponents)
        {
            overlayComponent.SetActive(false);
        }
    }

    public void Unslice()
    {
        foreach (GameObject overlayComponent in overlayComponents)
        {
            overlayComponent.SetActive(true);
        }
    }
}
