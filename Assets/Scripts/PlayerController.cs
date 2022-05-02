using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem goldenParticles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            goldenParticles.Play();
        }
    }
}
