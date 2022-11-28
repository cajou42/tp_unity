using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    public GameManager game;
    public GameObject canvas;
    public TextMeshProUGUI info;
    float compteur = 120;
    int hunger;

    void Update()
    {
        hunger = game.villager.Length;
        textbox.text = "end of the day: " + Mathf.Floor(compteur).ToString();
        compteur -= Time.deltaTime;
        if (compteur < 0)
        {
            if (game.products.Length == 0)
            {
                canvas.SetActive(true);
                info.text = "Game Over";
                Time.timeScale = 0;
            }
            for (int i = 0; i < game.products.Length; i++)
            {
                var text = game.products[i].transform.GetChild(0).GetComponent<TextMeshPro>();
                if (text.text == "Berry")
                {
                    Destroy(game.products[i]);
                    hunger--;
                }
                if (hunger == 0)
                {
                    hunger = game.villager.Length;
                    compteur = 120;
                    break;
                }
                else if(hunger != 0 && i == game.products.Length-1)
                {
                    Debug.Log("aaaaaaaaaa");
                    canvas.SetActive(true);
                    info.text = "Game Over";
                    Time.timeScale = 0;
                }
            }
        }
        if (Input.GetKeyDown("p"))
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
