using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Multiples : MonoBehaviour
{
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (counter = 0; counter <= 100; counter++)
        {
            if(counter % 3 == 0 || counter % 5 == 0)
            {
                print("Programming is Awesome!!");
            }
            else
            {
                print(counter);
            }
        }        
    }
}
