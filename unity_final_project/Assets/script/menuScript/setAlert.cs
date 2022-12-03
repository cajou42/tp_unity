using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class setAlert : MonoBehaviour
{
    public GameManager game;
    public GameObject textbox;

    private void Update()
    {
        if (game.nb_cards + 3 >= 15)
        {
            textbox.SetActive(true);
        }
        else
        {
            textbox.SetActive(false);
        }

    }
}
