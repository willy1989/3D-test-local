using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_TransitionNode : TransitionNode
{
    [SerializeField] private TransitionCameraManager transitionCameraManager;

    private CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public override void TransitionIn()
    {
        transitionCameraManager.SwitchCamera(virtualCamera);
    }

    public override void TransitionOut()
    {
        virtualCamera.Priority= 0;
    }
}
