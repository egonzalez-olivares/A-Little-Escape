using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerScript : MonoBehaviour {

    GameController gameController;
    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            Debug.Log("Could not find GameController script for WinTrigger");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameController.WinGame();
        }
    }
}
