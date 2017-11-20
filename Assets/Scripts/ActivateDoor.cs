using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDoor : MonoBehaviour {

    [SerializeField]
    private GameObject playerObject;

    [SerializeField]
    private GameObject door;

    private PlayerSpecial playerSpecial;
	// Use this for initialization
	void Start () {
        playerSpecial = playerObject.GetComponent<PlayerSpecial>();
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && playerSpecial.enabled == true)
        {
            door.GetComponent<LevelMovement>().enabled = true;
        }
    }
}
