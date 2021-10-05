using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FibonacciScript : MonoBehaviour
{
    public int n1 = 0;
    public int n2 = 1;
    public int n3 = 0;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        print(n1);
        print(n2);
        while (i < 19)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
            print(n3);
            i++;
        }
    }
}
