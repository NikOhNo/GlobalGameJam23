using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    [SerializeField]
    GameObject towerPrefab;

    protected float attackRange;

    protected private float timeBetweenAttacks;

    protected private bool canPlaceOnTrack;

    protected private int costToPlace;
}

public interface ITowerAttack
{
    void Attack();
}