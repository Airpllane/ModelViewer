using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManagerPresenter : MonoBehaviour
{
    public Transform contentView;
    public ModelManager modelManager;
    public ModelButtonPresenter modelButtonPresenter;
    public ModelPresenter modelPresenter;

    private int objectNumber;
    public delegate void ButtonDelegate(int objectNumber);

    void Start()
    {
        LoadModels();
    }

    public void LoadModels()
    {
        List<Model> modelList = modelManager.modelList;
        for (int i = 0; i < modelList.Count; i++)
        {
            AddButton(modelList[i]);
        }
    }

    public void AddButton(Model model)
    {
        ModelButtonPresenter buttonPresenter = Instantiate(modelButtonPresenter, contentView);
        buttonPresenter.InjectModel(model);

        buttonPresenter.ButtonClicked += ButtonPresenterClicked;
    }

    private void ButtonPresenterClicked(Model model)
    {
        modelPresenter.InjectModel(model);
    }
}
