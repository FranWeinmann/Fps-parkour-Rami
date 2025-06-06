using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 respawnPoint;

    void Start()
    {
        respawnPoint = transform.position;  // Inicialmente en su posición inicial
    }

    public void SetRespawnPoint(Vector3 newRespawnPoint)
    {
        respawnPoint = newRespawnPoint;
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        // Aquí puedes reiniciar salud, animaciones, etc.
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
            Debug.Log("Respawning jugador a " + respawnPoint);
        }
    }
}
