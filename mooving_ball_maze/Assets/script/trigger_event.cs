using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_event : MonoBehaviour
{
    public replace_ball aball;

    private void OnTriggerEnter(Collider other)
    {
        if (aball.checkpoint)
        {
            GameObject.Find("Sphere").transform.position = new Vector3(-0.027f, 22, 10);
        }
        else
        {
            GameObject.Find("Sphere").transform.position = new Vector3(0, 22, -10);
        }
        GameObject.Find("Sphere").GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}
