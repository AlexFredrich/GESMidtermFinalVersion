using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerRespawn playerRespawn = col.gameObject.GetComponent<PlayerRespawn>();
            playerRespawn.Respawn();
        }
    }
}
