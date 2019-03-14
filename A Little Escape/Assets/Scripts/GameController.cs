using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public int collectedKeys;
    public RawImage firstKey;
    public RawImage secondKey;
    public RawImage thirdKey;
    public Text doorUnlocked;
    public Text winText;
    public GameObject door;
    public RawImage blackScreen;

    private int totalKeys;
    private float alpha;
    private float alphaScreen;
    private bool endGame;
    

	// Use this for initialization
	void Start () {
        collectedKeys = 0;
        totalKeys = 3;
        winText.text = "";
        doorUnlocked.text = "";
        alpha = 0.0f;
        alphaScreen = 0.0f;
        firstKey.CrossFadeAlpha(alpha, 0, true);
        secondKey.CrossFadeAlpha(alpha, 0, true);
        thirdKey.CrossFadeAlpha(alpha, 0, true);
        blackScreen.CrossFadeAlpha(alphaScreen, 0, true);
        endGame = false;
    }

    private void Update()
    {
        if(collectedKeys == totalKeys)
        {
            alpha = 0.0f;
            doorUnlocked.text = "Door Unlocked!";
            door.GetComponent<Rigidbody>().isKinematic = false;
            doorUnlocked.CrossFadeAlpha(alpha, 2, false);
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
        //blackScreen.GetComponent<Image>().color = Color.Lerp(clear, black, fadeSpeed * Time.deltaTime);
        alphaScreen = 1.0f;
        Debug.Log("Fading to black...");
        blackScreen.CrossFadeAlpha(alphaScreen, 3.0f, false);
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
