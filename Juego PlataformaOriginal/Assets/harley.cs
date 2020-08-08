﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harley : MonoBehaviour
{

    public Transform from;
    public Transform to;


    void OnDrawGizmosSelected()
    {
        if (from != null && to != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(from.position, to.position);
            Gizmos.DrawSphere(from.position, 0.3f);
            Gizmos.DrawSphere(to.position, 0.3f);
        }

    }
}
