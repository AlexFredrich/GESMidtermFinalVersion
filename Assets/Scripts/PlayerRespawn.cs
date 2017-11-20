using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour {

public void Respawn()
    {
        if(Checkpoint.currentCheckpoint != null)
        {
            gameObject.transform.position = Checkpoint.currentCheckpoint.transform.position;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
