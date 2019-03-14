using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour {
    public Rigidbody painting;

    // Use this for initialization
    void Start() {
        painting = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

        }
    }
}
