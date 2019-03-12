using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int collectedKeys;
    public RawImage basementKey;
    public RawImage firstKey;
    public RawImage secondKey;

    private int totalKeys;

	// Use this for initialization
	void Start () {
        collectedKeys = 0;
        totalKeys = 3;
	}
	
	public void KeyPickup()
    {
        switch(collectedKeys)
        {
            case 1:
                Debug.Log("First key");
                break;
            case 2:
                Debug.Log("Second key");
                break;
            case 3:
                Debug.Log("Third Key");
                break;
            default:break;
        }
    }
}
