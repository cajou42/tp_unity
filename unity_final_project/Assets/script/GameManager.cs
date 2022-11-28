using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int nb_cards = 0;
    public int nb_gold = 0;
    public GameObject[] products;
    public GameObject[] ressources;
    public GameObject[] villager;

    void FixedUpdate()
    {
        products = GameObject.FindGameObjectsWithTag("Product");
        ressources = GameObject.FindGameObjectsWithTag("Ressources");
        villager = GameObject.FindGameObjectsWithTag("Villager");
        nb_cards = products.Length + ressources.Length + villager.Length;
    }
}
