using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen_TransitionNode : TransitionNode
{
    [SerializeField] private GameObject fullScreenGameObject;

    public override void TransitionIn()
    {
        fullScreenGameObject.SetActive(true);
    }

    public override void TransitionOut()
    {
        fullScreenGameObject.SetActive(false);
    }
}
