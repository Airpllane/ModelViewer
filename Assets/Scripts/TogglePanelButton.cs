using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePanelButton : MonoBehaviour
{
    public GameObject panel;
    public Button button;
    void Awake()
    {
        button.onClick.AddListener(TogglePanel);
    }

    void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
