using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text textbox;
    float compteur = 0;

    void Start()
    {

    }

    void Update()
    {
        textbox.text = "timer: " + compteur.ToString();
        compteur += Time.deltaTime;
    }
}
