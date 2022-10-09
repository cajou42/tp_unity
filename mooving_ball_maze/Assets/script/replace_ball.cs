using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replace_ball : MonoBehaviour
{
    private Vector3 vect = new Vector3(0, -30, 0);
    public bool checkpoint = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Sphere").transform.position.y < -50)
        {
            GameObject.Find("Sphere").transform.position = new Vector3(0, 22, -10);
            GameObject.Find("Sphere").GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
     
    }

}
