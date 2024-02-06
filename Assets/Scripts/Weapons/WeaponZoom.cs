using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 1f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    //[SerializeField] StarterAssets.FirstPersonController fpsController;

    bool zoomedInToggle = false;
    StarterAssets.FirstPersonController fpsController;

    private void Start()
    {
        fpsController =  GetComponent<StarterAssets.FirstPersonController>();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
            fpsController.RotationSpeed = zoomInSensitivity;
        }
        else if (Input.GetMouseButtonUp(1))
        {

            fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
            fpsController.RotationSpeed = zoomOutSensitivity;
        }
    }



}
