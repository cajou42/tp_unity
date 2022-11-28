using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class move_card : MonoBehaviour, IDragHandler
{

    void Start()
    {
        Cursor.visible = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(vector);
        if (transform.parent != null)
        {
            transform.parent = null;
        }
    }

}