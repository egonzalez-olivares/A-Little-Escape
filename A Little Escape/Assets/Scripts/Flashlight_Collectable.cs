using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Collectable : MonoBehaviour {
    public GameObject FlashlightPlayer;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(new Vector3(0.1f, 0.5f, 0.1f), 0.5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("First collision");
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Collision!");
            // Enable FlashlightPlayer
            FlashlightPlayer.gameObject.SetActive(true);

            // destroy the flashlight
            GameObject.Destroy(this.gameObject);
        }
    }
}
