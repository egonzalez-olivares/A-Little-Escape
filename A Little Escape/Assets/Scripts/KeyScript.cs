using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

    GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            Debug.Log("Could not find GameController script");
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameController.collectedKeys++;
            gameController.KeyPickup();
            Destroy(gameObject);
            
        }
    }
}
