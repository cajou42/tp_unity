using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    private GameObject obj;
    public float timer;
    private bool cooldown = false;

    void Start()
    {
        timer = 0;
        InvokeRepeating("generateObstacle", 0, 1);
    }
    
    void generateObstacle()
    {
        if(timer == 0)
        {
            switch (Random.Range(0, 3))
            {
                case 0 :
                    obj = Instantiate(obstacle1, new Vector3(12, -2.6f, 0), Quaternion.identity);
                    cooldown = true;
                    break;
                case 1 :
                    if (cooldown)
                    {
                        obj = Instantiate(obstacle2, new Vector3(12, -1.57f, 0), Quaternion.identity);
                        cooldown = false;
                    }
                    else
                    {
                        obj = Instantiate(obstacle1, new Vector3(12, -2.6f, 0), Quaternion.identity);
                    }
                    break;
                case 2 :
                    if (cooldown)
                    {
                        obj = Instantiate(obstacle3, new Vector3(12, -2.4f, 0), Quaternion.identity);
                        cooldown = false;
                    }
                    else
                    {
                        obj = Instantiate(obstacle1, new Vector3(12, -2.6f, 0), Quaternion.identity);
                    }
                    break;

            }
            timer = Random.Range(1, 5);
        }
        timer--;
    }
}
