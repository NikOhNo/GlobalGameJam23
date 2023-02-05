using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Vector3 shootPosition;

    private void Awake()
    {
        shootPosition = transform.Find("ProjectileShootFromPosition").position;
    }
}