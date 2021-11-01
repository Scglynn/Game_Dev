using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print("the sphere has entered the " + other.gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        print("the sphere is still in the " + other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        print("the sphere has left the " + other.gameObject.name);
    }
}
