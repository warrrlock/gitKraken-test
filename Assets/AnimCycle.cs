using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using UnityEngine;

public class AnimCycle : MonoBehaviour
{
    public Sprite[] walkAnim = new Sprite[2];
    private int currentFrame;
    private float animFPS = 10;
    private float previousFrameTime;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = walkAnim[currentFrame];

        if (Time.time - previousFrameTime > 1 / animFPS) {
            previousFrameTime = Time.time;
            currentFrame++;
            if (currentFrame > walkAnim.Length - 1) currentFrame = 0;
        }
    }
}
