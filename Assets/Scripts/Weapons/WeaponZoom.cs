using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] StarterAssets.FirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 1f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    //[SerializeField] StarterAssets.FirstPersonController fpsController;

    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            ZoomIn();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            ZoomOut();

        }
    }

    private void ZoomIn()
    {
        fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
        fpsController.RotationSpeed = zoomInSensitivity;
    }

    private void ZoomOut()
    {
        fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
        fpsController.RotationSpeed = zoomOutSensitivity;
    }

}
