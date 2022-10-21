using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    float compteur = 0;

    void Update()
    {
        textbox.text = "timer: " + Mathf.Floor(compteur).ToString();
        compteur += Time.deltaTime;
    }
}
