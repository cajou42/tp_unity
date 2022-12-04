using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Build : MonoBehaviour
{
    private GameObject[] products;
    private GameObject[] Construction = new GameObject[4];
    public GameObject loading;
    int nbFlint = 2;
    int nbWood = 2;
    int count = 0;
    float loadCount = 0.0015f;
    private bool verif = true;
    private Vector3 baseLoad = new Vector3();
    public Material HMaterial;
    public GameManager game;

    private void Start()
    {
        baseLoad = loading.transform.localScale;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        products = GameObject.FindGameObjectsWithTag("Product");
        count = 0;
        if (collision.tag == "Blueprint")
        {
            for(int i = 0; i < products.Length; i++){
                var text = products[i].transform.GetChild(0).GetComponent<TextMeshPro>();
                if (text.text == "Flint" && nbFlint != 0)
                {
                    
                    Construction[count] = products[i];
                    count++;
                    nbFlint--;
                }
                if (text.text == "Wood" && nbWood != 0)
                {
                    
                    Construction[count] = products[i];
                    count++;
                    nbWood--;
                }
            }
            count = 0;
            if (nbFlint == 0 && nbWood == 0)
            {
                if (verif)
                {
                    verif = false;
                    loading.SetActive(true);
                    StartCoroutine(DelayBuild(collision.transform));
                }
            }
        }
    }

    private void Update()
    {
        if (!verif)
        {
            float size = loading.GetComponent<Renderer>().bounds.size.x;

            Vector3 rescale = loading.transform.localScale;

            rescale.x = loadCount * rescale.x / size;

            loading.transform.localScale = rescale;
            loadCount += 0.0015f;
        }
    }

    IEnumerator DelayBuild(Transform collision)
    {
        yield return new WaitForSeconds(5);

        var text = collision.GetChild(0).GetComponent<TextMeshPro>();
        text.text = "House";
        collision.GetComponent<SpriteRenderer>().material = HMaterial;
        for (int i = 0; i < Construction.Length; i++)
        {
            Destroy(Construction[i]);
        }

        verif = true;
        loading.SetActive(false);
        loading.transform.localScale = baseLoad;
        loadCount = 0.0015f;
        game.villager_limits++;
    }
}
