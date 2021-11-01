using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    private int Counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool isSolved = false;
    void OnTriggerEnter(Collider collider)
    {
        
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
            Counter++;

        }
        if (Counter == 4)
        {
            SceneManager.LoadScene("RetryGame");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
