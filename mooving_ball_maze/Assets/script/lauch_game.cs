using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lauch_game : MonoBehaviour
{

    public void Lauch(string scene)
    {
        Debug.Log("alu");
        SceneManager.LoadScene(scene);
    }
}
