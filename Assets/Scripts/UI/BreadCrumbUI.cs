using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BreadCrumbUI : MonoBehaviour
{
    [SerializeField] private Button breadCrumbButtonPrefab;

    [SerializeField] private TransitionManager transitionManager;

    private Button lastAddedButton;

    private void Awake()
    {
        transitionManager.AddNodeEvent += AddButton;
        transitionManager.GoBackToPreviousNodeEvent += RemoveLastButton;
    }

    private void AddButton(TransitionNode transitionNode)
    {
        Button button = Instantiate(breadCrumbButtonPrefab, this.transform);

        lastAddedButton = button;

        button.GetComponentInChildren<TextMeshProUGUI>().text = transitionNode.name;
    }

    private void RemoveLastButton()
    {
        if(lastAddedButton != null) 
            Destroy(lastAddedButton.gameObject);
    }
}
