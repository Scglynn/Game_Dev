using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        if (hVal != 0)
            transform.Translate(hVal, 0, 0);
        if (vVal != 0)
            transform.Translate(0, vVal, 0);
        
    }
}
