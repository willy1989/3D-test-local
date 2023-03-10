using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTarget : MonoBehaviour
{
    [SerializeField] private TransitionManager transitionManager;

    [SerializeField] private TransitionNode transitionNode;

    public void AddNode()
    {
        transitionManager.AddNode(transitionNode);
    }
}
