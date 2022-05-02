using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem goldenParticles;
    public ParticleSystem afterGV;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            goldenParticles.Play();
            //Play move animation
            //turn on Golden Circle
            //turn on Strength Power Up Sign
            //turn on Defense Power Up Sign
            //wait a little
            //turn off Golden Circle
            afterGV.Play();
            //wait for a little bit
        }
    }
}
