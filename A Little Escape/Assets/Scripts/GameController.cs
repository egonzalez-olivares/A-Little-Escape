using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int collectedKeys;
    public RawImage firstKey;
    public RawImage secondKey;
    public RawImage thirdKey;
    public Text doorUnlocked;
    public Text winText;
    public GameObject door;
    public GameObject blackScreen;

    private int totalKeys;
    private float alpha;
    

	// Use this for initialization
	void Start () {
        collectedKeys = 0;
        totalKeys = 3;
        winText.text = "";
        doorUnlocked.text = "";
        alpha = 0.0f;
        firstKey.CrossFadeAlpha(alpha, 0, true);
        secondKey.CrossFadeAlpha(alpha, 0, true);
        thirdKey.CrossFadeAlpha(alpha, 0, true);

        blackScreen = GameObject.Find("Canvas/BlackScreen");
        blackScreen.GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }

    private void Update()
    {
        if(collectedKeys == totalKeys)
        {
            alpha = 0.0f;
            doorUnlocked.text = "Door Unlocked!";
            door.GetComponent<Rigidbody>().isKinematic = false;
            doorUnlocked.CrossFadeAlpha(alpha, 2, true);
        }

    }

    public void KeyPickup()
    {
        alpha = 1.0f;
        switch(collectedKeys)
        {
            case 1:
                Debug.Log("First key");
                firstKey.CrossFadeAlpha(alpha, 1, true);
                break;
            case 2:
                Debug.Log("Second key");
                secondKey.CrossFadeAlpha(alpha, 1, true);
                break;
            case 3:
                Debug.Log("Third Key");
                thirdKey.CrossFadeAlpha(alpha, 1, true);
                break;
            default:break;
        }
    }

    public void WinGame()
    {
        winText.text = "Congratulations!\n You escaped!";
        Invoke("GoBlack", 3);
    }
    void GoBlack()
    {
        blackScreen.GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }
}
