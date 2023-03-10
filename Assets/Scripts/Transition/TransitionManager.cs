using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    private TransitionNode tailNode;

    private void GoToPreviousNode()
    {
        if (tailNode == null)
            return;

        tailNode.TransitionOut();

        if (tailNode != null)
            tailNode = tailNode.Parent;

        tailNode.TransitionIn();
    }

    public void AddNode(TransitionNode node)
    {
        if (tailNode != null)
            tailNode.TransitionOut();

        node.TransitionIn();

        node.Parent = tailNode;

        tailNode = node;
    }
}
