using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    private TransitionNode tailNode;

    private void GoToPreviousNode()
    {
        if (tailNode != null)
            tailNode = tailNode.Parent;
    }

    private void AddNode(TransitionNode node)
    {
        node.Parent = tailNode;

        tailNode = node;
    }
}
