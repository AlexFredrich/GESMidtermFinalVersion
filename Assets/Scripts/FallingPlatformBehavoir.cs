using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformBehavoir : MonoBehaviour {

    private Rigidbody2D rb2D;
    private Vector3 initialPosition;

    [SerializeField]
    private float fallDelay;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.CompareTag("Player"))
        {
            StartCoroutine(Fall(fallDelay));
            rb2D.bodyType = RigidbodyType2D.Kinematic;
        }
        else
        {
            transform.position = initialPosition;
            rb2D.bodyType = RigidbodyType2D.Kinematic;
        }

    }

    IEnumerator Fall(float fallDelay)
    {
        while (fallDelay > 0 && fallDelay > -5)
        {
            rb2D.position = new Vector2(rb2D.position.x + (Random.insideUnitCircle.x * 0.05f), rb2D.position.y);
            yield return new WaitForSeconds(0.0001f);
            fallDelay -= Time.deltaTime;
        }

        rb2D.bodyType = RigidbodyType2D.Dynamic;

    }
}
