using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        var text = transform.GetChild(0).GetComponent<TextMeshPro>();
        var text_product = collision.transform.GetChild(0).GetComponent<TextMeshPro>();
        if (text.text == text_product.text)
        {
            CheckChild(transform, collision.transform);
        }
    }

    void CheckChild(Transform parent, Transform child)
    {
        if(parent.childCount == 1)
        {
            child.SetParent(parent);
            child.position = new Vector2(parent.position.x, parent.position.y-0.5f);
        }
        else if(parent.childCount == 2)
        {
            CheckChild(parent.GetChild(1), child);
        }
    }
}
