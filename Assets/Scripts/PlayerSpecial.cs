using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpecial : MonoBehaviour {

    private GameObject obstacle;
    private Rigidbody2D obstacleRigidBody;

	// Use this for initialization
	void Start () {


        obstacle = GameObject.Find("Obstacle");
        obstacleRigidBody = obstacle.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1"))
        {
            obstacleRigidBody.gravityScale = 0;
            Physics2D.IgnoreLayerCollision(8, 10, true);
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
        }
        else
        {
            obstacleRigidBody.gravityScale = 1;
            Physics2D.IgnoreLayerCollision(8, 10, false);
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
	}
}
