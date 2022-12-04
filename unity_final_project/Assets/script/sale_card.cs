using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sale_card : MonoBehaviour
{
    public GameManager gameManager;
    public Material GMaterial;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var text = collision.transform.GetChild(0).GetComponent<TextMeshPro>();
        if(text.text != "gold")
        {
            collision.transform.tag = "Gold";
            text.text = "gold";
            collision.GetComponent<SpriteRenderer>().material = GMaterial;
            gameManager.nb_gold++;
        }
    }
}