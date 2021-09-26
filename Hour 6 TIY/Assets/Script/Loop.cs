using UnityEngine;

public class Loop : MonoBehaviour
{
    public int sum;
    int count = 499;
    void Start()
    {
        while(count <= 499 || count != 2)
        {
            if(count % 2 == 0)
            {
                sum += count;
            }
            count--;
        }
        print(sum);
    }
}
