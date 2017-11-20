using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour {

    public static Checkpoint currentCheckpoint;
    private Animator anim;
    [SerializeField]
    private GameObject UIScreen;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            currentCheckpoint = this;
            anim.SetBool("Activated", true);
            UIScreen.GetComponent<Text>().text = "Checkpoint Activated.";
        }
    }
}
