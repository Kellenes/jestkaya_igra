using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class slow : MonoBehaviour
{
    private void slow()
    {
        int i = 0;
        if (Input.GetKeyDown(KeyCode.E))
        {   
            Time.timeScale = 0.5F;
            movementSpeed = movementSpeed*2;
            while(i < 10)
            {
                i++;
            }
            Time.timeScale = 1;
            movementSpeed = movementSpeed/2;
        } 
        //Time.timeScale = 1;
        //movementSpeed = movementSpeed/2;
    }

}
//
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Time.timeScale == 0.5F)
            {
                Time.timeScale = 1;
                movementSpeed = movementSpeed/2;
            }

            else if(Time.timeScale == 1)
            {
                Time.timeScale = 0.5F;
                movementSpeed = movementSpeed*2;
            }
        }   
    }
//
//
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0.5F;
            movementSpeed = movementSpeed*2;
            Thread.Sleep(5000);   //остонавливает абсолютно всё
            Time.timeScale = 1;
            movementSpeed = movementSpeed/2;         
        }
    }
//
//
    private void slow()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Time.timeScale == 1)
            {
                if(kd == true)
                {
                    Time.timeScale = 0.5F;
                    movementSpeed = movementSpeed*2;
                    Invoke(nameof(time), 3); //Waits for 3 seconds before calling "time"
                }  
            }   
        }
    }

    private void time()
    {
        Time.timeScale = 1F;
        movementSpeed = movementSpeed/2;
        kd = false;
        Invoke(nameof(normal), 6);
    }

    private void normal()
    {
        kd = true;
    }
//
