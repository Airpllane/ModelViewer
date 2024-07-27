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

        renderedModel = Instantiate(model.modelTemplate, modelContainer.transform);

        foreach (Ability ability in renderedModel.modelAbilities)
        {
            AbilityButtonPresenter buttonPresenter = Instantiate(abilityButtonPresenter, abilityView);
            buttonPresenter.InjectModel(ability);
            abilityButtons.Add(buttonPresenter);
        }
    }

    public void RemoveModel()
    {
        if (this.model)
        {
            if (renderedModel) Destroy(renderedModel.gameObject);
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
