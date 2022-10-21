using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;
    private int TouchGround = 2;
    public GameObject canvas;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && TouchGround != 0)
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            TouchGround --;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        TouchGround = 2;
        if (col.gameObject.name == "Obstacle1(Clone)" || col.gameObject.name == "Obstacle2(Clone)" || col.gameObject.name == "Obstacle3(Clone)")
        {
            canvas.SetActive(true);
            Destroy(this);
            Time.timeScale = 0;
        }
    }
}
