using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BreadCrumbUI : MonoBehaviour
{
    [SerializeField] private TransitionManager transitionManager;

    [SerializeField] private BreadCrumButton breadCrumbButtonPrefab;

    private Stack<BreadCrumButton> breadCrumButtons = new Stack<BreadCrumButton>();

    private void Awake()
    {
        transitionManager.AddNodeEvent += AddButton;

        transitionManager.GoToSpecificNodeEvent += RemoveButton;
    }

    private void AddButton(TransitionNode transitionNode)
    {
        BreadCrumButton button = Instantiate(breadCrumbButtonPrefab, this.transform);

        button.GetComponentInChildren<TextMeshProUGUI>().text= transitionNode.name;

        button.TransitionNode= transitionNode;

        button.Button.onClick.AddListener(() => { transitionManager.GoToSpecificNode(transitionNode); });

        breadCrumButtons.Push(button);
    }

    private void RemoveButton(TransitionNode targetTransitionNode)
    {
        BreadCrumButton currentBreadCrumbButton  = breadCrumButtons.Peek();

        while (currentBreadCrumbButton != null) 
        {
            if(currentBreadCrumbButton.TransitionNode == targetTransitionNode) 
                break;

            currentBreadCrumbButton = breadCrumButtons.Pop();

            Destroy(currentBreadCrumbButton.gameObject);

            currentBreadCrumbButton = breadCrumButtons.Peek();
        }
    }
}
