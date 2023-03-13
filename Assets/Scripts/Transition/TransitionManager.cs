using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionManager : MonoBehaviour
{
    [SerializeField] private TransitionNode startTransitionNode;

    [SerializeField] private Button backButton;

    private TransitionNode tailNode;

    public Action<TransitionNode> AddNodeEvent;

    public Action GoBackToPreviousNodeEvent;

    private void Awake()
    {
        backButton.onClick.RemoveAllListeners();
        backButton.onClick.AddListener(GoToPreviousNode);
    }

    private void Start()
    {
        AddNode(startTransitionNode);
    }

    private void GoToPreviousNode()
    {
        if (tailNode == null || tailNode.Parent == null)
            return;

        tailNode.TransitionOut();

        tailNode = tailNode.Parent;

        tailNode.TransitionIn();

        GoBackToPreviousNodeEvent?.Invoke();
    }

    public void AddNode(TransitionNode node)
    {
        if (tailNode != null)
            tailNode.TransitionOut();

        node.TransitionIn();

        node.Parent = tailNode;

        tailNode = node;

        AddNodeEvent?.Invoke(node);
    }
}
