using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    public GameObject prefab;
    public GameObject loading;
    private GameObject[] collectibles;
    public GameManager gameManager;
    private bool verif = true;
    float count = 0.0037f;
    private Vector3 baseLoad = new Vector3();

    private void Start()
    {
        baseLoad = loading.transform.localScale;
    }

    IEnumerator DelayCollect(TextMeshPro text, GameObject collectible)
    {
        yield return new WaitForSeconds(3);

        GameObject ROne = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject RTwo = Instantiate(prefab, new Vector3(-3, 0, 0), Quaternion.identity);
        GameObject RThree = Instantiate(prefab, new Vector3(3, 0, 0), Quaternion.identity);
        ROne.transform.tag = "Product";
        RTwo.transform.tag = "Product";
        RThree.transform.tag = "Product";
        var textOne = ROne.transform.GetChild(0).GetComponent<TextMeshPro>();
        var textTwo = RTwo.transform.GetChild(0).GetComponent<TextMeshPro>();
        var textThree = RThree.transform.GetChild(0).GetComponent<TextMeshPro>();
        switch (text.text)
        {
            case "Tree":
                textOne.text = "Wood";
                textTwo.text = "Wood";
                textThree.text = "Wood";
                Destroy(collectible);
                break;
            case "Bush":
                textOne.text = "Berry";
                textTwo.text = "Berry";
                textThree.text = "Berry";
                Destroy(collectible);
                break;
            case "Rock":
                textOne.text = "Flint";
                textTwo.text = "Flint";
                textThree.text = "Flint";
                Destroy(collectible);
                break;
        }
        verif = true;
        loading.SetActive(false);
        loading.transform.localScale = baseLoad;
        count = 0.0037f;
    }

    void Update()
    {
        collectibles = GameObject.FindGameObjectsWithTag("Ressources");
        foreach (GameObject collectible in collectibles)
        {
            var text = collectible.transform.GetChild(0).GetComponent<TextMeshPro>();
            if (Mathf.Round(transform.position.x) == Mathf.Round(collectible.transform.position.x) && Mathf.Round(transform.position.y) == Mathf.Round(collectible.transform.position.y) && gameManager.nb_cards + 3 < 15)
            {
                if (verif)
                {
                    verif = false;
                    loading.SetActive(true);
                    StartCoroutine(DelayCollect(text, collectible));
                }
            }

        }
        if (!verif)
        {
            float size = loading.GetComponent<Renderer>().bounds.size.x;

            Vector3 rescale = loading.transform.localScale;

            rescale.x = count * rescale.x / size;

            loading.transform.localScale = rescale;
            count += 0.0037f;
        }
    }
}
