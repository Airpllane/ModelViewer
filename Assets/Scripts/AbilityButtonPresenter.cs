using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButtonPresenter : MonoBehaviour
{
    public Button button;
    public TMP_Text buttonText;
    public Ability ability = null;

    private bool isActive = false;

    public void ToggleAbility()
    {
        if (!isActive)
        {
            ability.Activate();
            isActive = true;
            button.GetComponent<Image>().color = Color.green;
        }
        else
        { 
            ability.Deactivate();
            isActive = false;
            button.GetComponent<Image>().color = Color.red;
        }
    }

    public void InjectModel(Ability ability)
    {
        this.ability = ability;
        buttonText.text = this.ability.abilityName;
        button.onClick.AddListener(ToggleAbility);
    }

    public void RemoveModel()
    {
        if (ability == null) return;
        ability = null;
        buttonText.text = "Null";
        button.onClick.RemoveListener(ToggleAbility);
    }
}
