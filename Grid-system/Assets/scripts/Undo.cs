using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undo : MonoBehaviour
{
    public deplacement deplacement;

    public void Back()
    {
        GameObject caisse = deplacement.last_position[^1].item;
        caisse.transform.position = deplacement.last_position[^1].placement;
        if(deplacement.last_position.Count != 1)
            deplacement.last_position.RemoveAt(deplacement.last_position.Count - 1);
    }
}
