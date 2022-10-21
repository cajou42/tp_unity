using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float speed;
    
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed);
        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }

}
