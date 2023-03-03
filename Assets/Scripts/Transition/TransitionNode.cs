using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TransitionNode : MonoBehaviour
{
    public TransitionNode Parent;

    public abstract void TransitionIn();

    public abstract void TransitionOut();
}
