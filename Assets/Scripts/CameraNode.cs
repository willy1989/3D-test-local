using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraNode : MonoBehaviour
{
    public CameraNode parentNode;

    public CameraNode childNode;

    private CinemachineVirtualCamera virtualCamera;

    public CinemachineVirtualCamera VirtualCamera => virtualCamera;
}
