using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespownPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter con: " + other.name);
        PlayerRespawn playerRespawn = other.GetComponent<PlayerRespawn>();
            Debug.Log("Jugador detectado, actualizando respawn point.");
            playerRespawn.SetRespawnPoint(transform.position);
    }

}
