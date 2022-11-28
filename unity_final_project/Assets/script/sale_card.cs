using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sale_card : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var text = collision.transform.GetChild(0).GetComponent<TextMeshPro>();
        if(text.text != "gold")
        {
            collision.transform.tag = "Gold";
            text.text = "gold";
            gameManager.nb_gold++;
        }
    }
}