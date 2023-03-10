using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransitionTargetClicker : MonoBehaviour
{
    private void Update()
    {
        ClickTransitionTarget();
    }

    private void ClickTransitionTarget()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                TransitionTarget transitionTarget = hit.collider.GetComponent<TransitionTarget>();

                if (transitionTarget != null)
                {
                    transitionTarget.AddNode();
                }
            }
        }
    }
}
