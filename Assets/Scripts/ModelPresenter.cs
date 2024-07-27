using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ModelPresenter : MonoBehaviour
{
    public Model model;
    public AbilityButtonPresenter abilityButtonPresenter;
    public GameObject modelContainer;
    public ModelPrefab renderedModel;

    public Transform abilityView;
    public TMP_Text nameLabel;
    public TMP_Text descriptionLabel;

    private List<AbilityButtonPresenter> abilityButtons = new List<AbilityButtonPresenter>();

    public void InjectModel(Model model)
    {
        RemoveModel();
        this.model = model;

        nameLabel.text = model.modelName;
        descriptionLabel.text = model.modelDescription;

        foreach(Ability ability in model.modelAbilities)
        {
            AbilityButtonPresenter buttonPresenter = Instantiate(abilityButtonPresenter, abilityView);
            buttonPresenter.InjectModel(ability);
            abilityButtons.Add(buttonPresenter);
        }

        renderedModel = model.RenderModelAt(modelContainer.transform);
    }

    public void RemoveModel()
    {
        if (this.model)
        {
            this.model.UnrenderModel();
            foreach (AbilityButtonPresenter abilityButton in abilityButtons)
            {
                Destroy(abilityButton.gameObject);
            }
            abilityButtons = new List<AbilityButtonPresenter>();
            nameLabel.text = "Null";
            descriptionLabel.text = "Null";
            renderedModel = null;
        }
    }
}
