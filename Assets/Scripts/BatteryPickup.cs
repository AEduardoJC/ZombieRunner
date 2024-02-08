using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addItensity = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLight>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLight>().AddLightIntensity(addItensity);
            Destroy(gameObject);
        }
    }
}
