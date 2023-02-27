using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private static CameraNode currentCameraNode;

    [SerializeField] private CameraNode overViewCameraNode;

    public CameraNode OverViewCameraNode => overViewCameraNode;

    private void Awake()
    {
        currentCameraNode = overViewCameraNode;
    }

    public void SwitchToNextCamera()
    {
        currentCameraNode.VirtualCamera.Priority = 0;

        CameraNode temp = currentCameraNode.childNode;

        if (temp != null)
        {
            currentCameraNode = temp;
            currentCameraNode.VirtualCamera.Priority = 1;
        }
    }

    public void SwitchToPreviousCamera()
    {
        currentCameraNode.VirtualCamera.Priority = 0;

        CameraNode temp = currentCameraNode.parentNode;

        if (temp != null)
        {
            currentCameraNode = temp;
            currentCameraNode.VirtualCamera.Priority = 1;
        }
    }

    public void SwitchToSpecificCamera(CameraNode cameraNode)
    {
        currentCameraNode.VirtualCamera.Priority = 0;

        CameraNode temp = cameraNode;

        if (temp != null)
        {
            currentCameraNode = temp;
            currentCameraNode.VirtualCamera.Priority = 1;
        }
    }
}
