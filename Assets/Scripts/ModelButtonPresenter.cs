using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModelButtonPresenter : MonoBehaviour
{
    public Button button;
    public TMP_Text buttonText;
    public Model model = null;
    public event Action<Model> ButtonClicked;

    public void RaiseEvent()
    {
        ButtonClicked?.Invoke(model);
    }

    public void InjectModel(Model model)
    {
        this.model = model;
        buttonText.text = this.model.modelName;
        button.onClick.AddListener(RaiseEvent);
    }

    public void RemoveModel()
    {
        if (model == null) return;
        model = null;
        buttonText.text = "Null";
        button.onClick.RemoveListener(RaiseEvent);
    }
}
