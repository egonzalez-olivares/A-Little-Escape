using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    public float cameraSpeed;
    public float jumpRate;
    public float maxPitch;
    public float minPitch;


    private Vector3 jump;
    private float nextJump = 0;
    private float yaw = 180.0f;
    private float pitch = 0.0f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * v * moveSpeed * Time.deltaTime;
        Vector3 sidestep = transform.right * h * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement + sidestep);

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextJump)
        {
            nextJump = Time.time + jumpRate;
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
	}

    private void Update()
    {
        yaw += cameraSpeed * Input.GetAxis("Mouse X");
        pitch -= cameraSpeed * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

        transform.eulerAngles = new Vector3( pitch, yaw, 0.0f);
    }
}
