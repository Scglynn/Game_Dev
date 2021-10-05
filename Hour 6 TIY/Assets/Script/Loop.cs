using UnityEngine;
using System.Collections;

public class Loop : MonoBehaviour
{
    public int sum = 0;
    public int count = 2;
    void Start()
    {
        for(count = 2; count <= 499; count++)
        {
            if(count % 2 == 0)
            {
                sum += count;
            }
        }
        print(sum);
    }
}
