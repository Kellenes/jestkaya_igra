using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingEnemie : MonoBehaviour
{
    private bool isOk = true;
    public Vector2 direction;
    public GameObject wall1;
    public GameObject wall2;

    void FixedUpdate()
    {
        while(isOk == true)
        {
            transform.Translate(direction); 
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject == wall1)
        {
            isOk = false;
        }
    }
}
