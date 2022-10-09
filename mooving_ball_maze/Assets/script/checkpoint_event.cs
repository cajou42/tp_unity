using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_event : MonoBehaviour
{
    public replace_ball ball;

    private void OnTriggerEnter(Collider other)
    {
        ball.checkpoint = true;
    }
}
