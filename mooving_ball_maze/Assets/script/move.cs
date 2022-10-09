using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(0, 0, 0);

        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * 10);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * 10);
        }

        if (Input.GetKey("z"))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 10);
        }

        if (Input.GetKey("s"))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 10);
        }
    }
}
