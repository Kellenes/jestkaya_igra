using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    private bool Entered = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = false;
        }
    }

    private void Update()
    {
        if (Entered)
        {
            Destroy(key);
            Destroy(door);
        }
    }
}
