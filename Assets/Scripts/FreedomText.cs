using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreedomText : MonoBehaviour {

    [SerializeField]
    private GameObject UIScreen;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            UIScreen.GetComponent<Text>().text = "Freedom at last!";
        }
    }

}
