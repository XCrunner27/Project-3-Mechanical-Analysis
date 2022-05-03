using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public GameObject thePlayer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thePlayer.GetComponent<Animator>().Play("PlayerMovement");
        }
    }
}
