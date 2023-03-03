using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TransitionCameraManager : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera currentVirtualCamera;

    public void SwitchCamera(CinemachineVirtualCamera newCamera)
    {
        currentVirtualCamera.Priority = 0;
        newCamera.Priority= 1;

        currentVirtualCamera = newCamera;
    }
}
