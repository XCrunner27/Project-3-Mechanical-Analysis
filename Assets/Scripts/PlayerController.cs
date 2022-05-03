using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem goldenParticles;
    public ParticleSystem afterGV;
    public Image defense;
    public Image strength;
    public Image goldenVowSpell;

    public void Awake()
    {
        goldenVowSpell.enabled = false;
        defense.enabled = false;
        strength.enabled = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            goldenParticles.Play();
            goldenVowSpell.enabled = true;
            defense.enabled = true;
            strength.enabled = true;
            yield return new WaitForSeconds(2);
            goldenVowSpell.enabled = false;
            afterGV.Play();
            yield return new WaitForSeconds(7);
            afterGV.Stop();
            defense.enabled = false;
            strength.enabled = false;
        }
    }

    IEnumerator goldenCircleOff()
    {
        yield return new WaitForSeconds(2);
        goldenVowSpell.enabled = false;
    }
    
    
    
    IEnumerator turnPowerUpOff()
    {
        yield return new WaitForSeconds(6);
        afterGV.Stop();
        defense.enabled = false;
        strength.enabled = false;
    }
}
