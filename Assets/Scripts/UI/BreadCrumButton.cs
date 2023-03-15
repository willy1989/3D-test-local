using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BreadCrumButton : MonoBehaviour
{
    [HideInInspector] public TransitionNode TransitionNode;

    public Button Button { get; private set; }

    private void Awake()
    {
        Button = GetComponent<Button>();
    }
}
