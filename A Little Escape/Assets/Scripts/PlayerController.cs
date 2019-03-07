using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float rotationSpeed;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * v * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        float turn = h * rotationSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0f, turn, 0f);

        rb.MoveRotation(rb.rotation * rotation);
	}
}
