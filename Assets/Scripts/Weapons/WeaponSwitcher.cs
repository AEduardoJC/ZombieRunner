using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currenWeapon = 0;

    void Start()
    {
        SetWeaponActive();

    }


    void Update()
    {
        int previousWeapon = currenWeapon;
        ProcessKeyInput();
        ProcessScrollWheel();

        if (previousWeapon != currenWeapon)
        {
            SetWeaponActive();
        }

    }

    private void ProcessScrollWheel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currenWeapon >= transform.childCount - 1)
            {
                currenWeapon = 0;
            }
            else
            {
                currenWeapon++;
            }
        }

         if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currenWeapon <= 0)
            {
                currenWeapon = transform.childCount -1;
            }
            else
            {
                currenWeapon--;
            }
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currenWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currenWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currenWeapon = 2;
        }
    }


    private void SetWeaponActive()
    {
        int weaponIndex = 0;
        foreach (Transform weapon in transform)
        {
            if (weaponIndex == currenWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

}
