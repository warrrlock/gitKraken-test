using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class spacebar_function : MonoBehaviour
{
    public int myCount = 0;
    public int victoryCount = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is debug");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myCount++;
           
        }

        if (myCount == victoryCount)
        {
            Debug.Log("WIN WIN WIN");
        }
    }
}
