﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    private Vector3 posB;

    private Vector3 posA;

    private Vector3 nexPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;

    // Use this for initialization
    void Start()
    {
        posA = childTransform.localPosition;
        posB = transformB.localPosition;

        nexPos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        // Hvis afstand mellem Smallplatform/ChildTransform og nexPos er = eller mindre end 0.1 skift retning.
        if (Vector3.Distance(childTransform.localPosition, nexPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);
    }

    private void ChangeDestination()
    {
        // If nexPos isn't equal to posA then we need to use posA, if it is equal then use B. Minder om if statement.
        nexPos = nexPos != posA ? posA : posB;
    }

}
