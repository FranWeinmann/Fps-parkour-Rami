﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("a");
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
