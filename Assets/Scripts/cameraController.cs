using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    [SerializeField]
    Transform objectToFollow;

    [SerializeField]
    float yOffset;

    [SerializeField]
    float xOffset;

    [SerializeField]
    float cameraSpeed;

    float zOffset;

	// Use this for initialization
	void Start ()
    {
        zOffset = transform.position.z;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 playerPosition = new Vector3(objectToFollow.position.x + xOffset, objectToFollow.position.y + yOffset, zOffset);
        Vector3 adjustedPosition = Vector3.Lerp(transform.position, playerPosition, cameraSpeed * Time.deltaTime);

        transform.position = adjustedPosition;
	}
}
