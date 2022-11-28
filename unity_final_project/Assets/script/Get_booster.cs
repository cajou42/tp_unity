using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Get_booster : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject prefab;
    public GameObject VillagerPrefab;
    int count = 1;
    private string type;

    void OnTriggerEnter2D(Collider2D collision)
    {
        count = CountChild(collision.transform,count);
        Debug.Log(count);
        if (count < 3 || (count > 3 && count < 6 && count != 3) || (count > 6 && count < 10 && count !=3 && count != 6) || count > 10)
        {
            Debug.Log("alu");
            count = 1;
        }

        switch (transform.tag)
        {
            case "booster_3":
                if (count == 3 && collision.transform.tag == "Gold")
                {
                    Destroy(collision.transform.gameObject);
                    GameObject ROne = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
                    GameObject RTwo = Instantiate(prefab, new Vector3(-3, 0, 0), Quaternion.identity);
                    GameObject RThree = Instantiate(prefab, new Vector3(3, 0, 0), Quaternion.identity);
                    CardType(ROne);
                    CardType(RTwo);
                    CardType(RThree);
                    count = 1;
                }
                break;

            case "booster_6":
                if (count == 6 && collision.transform.tag == "Gold")
                {
                    Destroy(collision.transform.gameObject);
                    GameObject ROne = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
                    var text = ROne.transform.GetChild(0).GetComponent<TextMeshPro>();
                    text.text = "Blueprint";
                    ROne.tag = "Blueprint";
                    count = 1;
                }
                break;

            case "booster_10":
                if (count == 10 && collision.transform.tag == "Gold")
                {
                    Destroy(collision.transform.gameObject);
                    GameObject ROne = Instantiate(VillagerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                    var text = ROne.transform.GetChild(0).GetComponent<TextMeshPro>();
                    text.text = "Villager";
                    count = 1;
                }
                break;
        }
    }

    int CountChild(Transform parent, int count)
    {
        if (parent.childCount == 2)
        {
            count++;
            count = CountChild(parent.GetChild(1), count);
        }
        return count;
    }

    void CardType(GameObject obj)
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                type = "Bush";
                break;
            case 1:
                type = "Tree";
                break;
            case 2:
                type = "Rock";
                break;
        }
        var text = obj.transform.GetChild(0).GetComponent<TextMeshPro>();
        text.text = type;
        obj.tag = "Ressources";
    }

}