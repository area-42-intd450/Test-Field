using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicktest : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log(gameObject.name + " was clicked!");
        // Put any other interaction code here
    }
}
