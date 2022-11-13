using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public struct Replace
{

    public Vector2 placement { get;}
    public GameObject item { get; }
    public Replace(Vector2 p, GameObject s)
    {
        placement = p;
        item = s;
    }
}

public class deplacement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public GameObject canvas;
    private Vector2 direction;
    public List<Replace> last_position = new List<Replace>();
    public int place;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("z"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * 10);
            direction = Vector2.up;
        }
            

        if (Input.GetKey("q"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * 10);
            direction = Vector2.left;
        }
            

        if (Input.GetKey("s"))
        {
            transform.Translate(Vector2.down * Time.deltaTime * 10);
            direction = Vector2.down;
        }
            

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * Time.deltaTime * 10);
            direction = Vector2.right;
        }
            

        if (Input.GetKeyDown("p"))
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hitU = Physics2D.Raycast(transform.position, direction, 0.3f, LayerMask.GetMask("Caisse"));
        if (hitU.collider != null)
        {
            var replace = new Replace(hitU.collider.transform.position, hitU.collider.gameObject);
            last_position.Add(replace);
            GameObject caisse = GameObject.Find(hitU.collider.name);
            caisse.transform.Translate(direction * Time.deltaTime * 25);
            Debug.DrawRay(transform.position, direction);
        }
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if(col.gameObject.name == "Tilemap_caisse")
    //    {
    //        last_position.Add(col.transform.position);
    //        for (int k = 0; k < col.contacts.Length; k++)
    //        {
    //            if (Vector3.Angle(col.contacts[k].normal, Vector3.down) <= 30)
    //            {
    //                col.transform.Translate(Vector2.up * Time.deltaTime * 25);
    //            }
    //            else if (Vector3.Angle(col.contacts[k].normal, Vector3.up) <= 30)
    //            {
    //                col.transform.Translate(Vector2.down * Time.deltaTime * 25);
    //            }
    //            else if (Vector3.Angle(col.contacts[k].normal, Vector3.right) <= 30)
    //            {
    //                col.transform.Translate(Vector2.left * Time.deltaTime * 25);
    //            }
    //            else if (Vector3.Angle(col.contacts[k].normal, Vector3.left) <= 30)
    //            {
    //                col.transform.Translate(Vector2.right * Time.deltaTime * 25);
    //            }
    //        }
    //    }
    //}
}
