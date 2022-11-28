using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject canvas;
    public void Go()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
    }
}
