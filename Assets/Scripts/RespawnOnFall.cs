using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnFall : MonoBehaviour
{
    public float yRespawn;
    public RespownPoint respawnPoint;
    public Transform SpawnPoint;

    void Start()
    {
        respawnPoint = FindObjectOfType<RespownPoint>();
    }

    void Update()
    {
        if (transform.position.y < yRespawn)
        {
            // Aquí leemos la variable zone directamente
            if (respawnPoint.zone == "New")
            {
                transform.position = SpawnPoint.position;
            }
            else
            {
                SceneManager.LoadScene("Fps");
            }
        }
    }
}
