using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {

    private AudioSource audioSource;
    private BoxCollider2D boxCollider2D;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
        boxCollider2D.enabled = false;
        spriteRenderer.enabled = false;

        Destroy(gameObject);
    }

}
