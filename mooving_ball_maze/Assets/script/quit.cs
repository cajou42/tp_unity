using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}
