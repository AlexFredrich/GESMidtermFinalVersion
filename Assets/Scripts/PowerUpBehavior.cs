using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpBehavior : MonoBehaviour {

    private AudioSource audioSource;
    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;
    private PlayerSpecial playerSpecial;

    [SerializeField]
    private GameObject playerGameObject;

    [SerializeField]
    private GameObject UIScreen;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        circleCollider2D = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerSpecial = playerGameObject.GetComponent<PlayerSpecial>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
        circleCollider2D.enabled = false;
        spriteRenderer.enabled = false;
        playerSpecial.enabled = true;
        UIScreen.GetComponent<Text>().text = "Hold 'ctrl' to faze through certain material. \nUse your power to escape.";

        Destroy(gameObject);
    }
}
