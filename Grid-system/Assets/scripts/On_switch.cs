using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class On_switch : MonoBehaviour
{
    public GameObject canvas;
    public GameObject menu;
    private TextMeshProUGUI remaining;
    public deplacement d;
    private int place;

    private void Start()
    {
        remaining = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        place = d.place;
    }

    private void Update()
    {
        place = d.place;
        if (place == 2)
        {
            menu.SetActive(true);
            TextMeshProUGUI txt = menu.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            txt.text = "Victoire !";
            place = 0;
            d.place = 0;
            Time.timeScale = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "caisse")
        {
            place ++;
            remaining.text = "Box on switch " + place + "/2";
            d.place = place;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "caisse")
        {
            place--;
            d.place = place;
            remaining.text = "Box on switch " + place + "/2";
        }
    }
}
