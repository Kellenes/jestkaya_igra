using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;

    public GameObject door;


    private int i = 0;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "button1")
        {
            if(i == 0)
            {

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    i = 1;
                }               
            }
        }

        if (collision.gameObject.name == "button2")
        {
            if(i == 1)
            {
                
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    i = 21;
                } 
            }
        }

        if (collision.gameObject.name == "button3")
        {
            if(i == 2)
            {
                
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    i = 3;
                } 
            }
        }

        if (collision.gameObject.name == "button4")
        {
            if(i == 3)
            {
                
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    i = 4;
                } 
            }
        }

        if (collision.gameObject.name == "button5")
        {
            if(i == 4)
            {
                
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Destroy(door);
                }         
            }
        }

        if (collision.gameObject.name == "button6")
        {
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                i = 0;
            } 
        }

        if (collision.gameObject.name == "button7")
        {
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                i = 0;
            } 
        }

        if (collision.gameObject.name == "button8")
        {
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                i = 0;
            } 
        }

        if (collision.gameObject.name == "button9")
        {
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                i = 0;
            } 
        }
    }

//    private void OnTriggerExit(Collider collision)
//    {
//    }
}