using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionManager : MonoBehaviour
{
    [SerializeField] private TransitionNode startTransitionNode;

    [SerializeField] private Button backButton;

    public TransitionNode TailNode;

    public Action<TransitionNode> AddNodeEvent;

    public Action<TransitionNode> GoToSpecificNodeEvent;

    private void Awake()
    {
        backButton.onClick.RemoveAllListeners();
        backButton.onClick.AddListener(() => GoToSpecificNode(TailNode.Parent));
    }

    private void Start()
    {
        AddNode(startTransitionNode);
    }

    public void GoToSpecificNode(TransitionNode targetNode)
    {
        if (TailNode == null)
            return;

        TailNode.TransitionOut();

        targetNode.TransitionIn();

        TailNode = targetNode;

        GoToSpecificNodeEvent?.Invoke(targetNode);
    }

    public void AddNode(TransitionNode node)
    {
        if (TailNode != null)
            TailNode.TransitionOut();

        node.TransitionIn();

        node.Parent = TailNode;

        TailNode = node;

        AddNodeEvent?.Invoke(node);
    }
}
