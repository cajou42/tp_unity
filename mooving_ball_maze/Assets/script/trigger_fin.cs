using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger_fin : MonoBehaviour
{
    public Text textbox;
    private void OnTriggerEnter(Collider other)
    {
        textbox.text = "you win";
    }
}
