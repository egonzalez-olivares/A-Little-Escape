using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Collectable : MonoBehaviour {
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0,5,0), 90.0f);
    }
}
