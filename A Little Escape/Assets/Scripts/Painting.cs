using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour {
    public Rigidbody painting;
    public AudioSource woodCrashSource;
    public AudioClip woodCrashClip;

    public bool paintingTriggered;

    // Use this for initialization
    void Start() {
        painting = GetComponent<Rigidbody>();
        woodCrashSource = GetComponent<AudioSource>();

        painting.isKinematic = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !paintingTriggered)
        {
            int chance = Random.Range(1, 50);

            Debug.Log("chance = " + chance);
            if (chance == 5)
            {
                StartCoroutine(PaintingFalls());
            }
        }
    }

    IEnumerator PaintingFalls()
    {
        painting.isKinematic = false;
        woodCrashSource.PlayOneShot(woodCrashClip, 0.75f);
        paintingTriggered = true;
        yield return new WaitForSeconds(1);
        painting.isKinematic = true;
    }
}
