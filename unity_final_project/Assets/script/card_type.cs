using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class card_type : MonoBehaviour
{
    private string type;

    void Start()
    {
        switch (Random.Range(0, 3)) {
            case 0 :
                type = "Villager";
                break;
            case 1:
                type = "Bush";
                break;
            case 2:
                type = "Tree";
                break;
            case 3:
                type = "Rock";
                break;
        }
        var text = transform.GetChild(0).GetComponent<TextMeshPro>();
        text.text = type;
    }

}
