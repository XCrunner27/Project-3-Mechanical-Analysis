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

    public Animator animatorForMovement;

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
            animatorForMovement.SetTrigger("Space Pressed");
            
            goldenParticles.Play();
            StartCoroutine(goldenCircleOff());
            afterGV.Play();


            IEnumerator goldenCircleOff()
            {
                goldenVowSpell.enabled = true;
                yield return new WaitForSeconds(3);
                defense.enabled = true;
                strength.enabled = true;
                goldenVowSpell.enabled = false;
                yield return new WaitForSeconds(5);
                defense.enabled = false;
                strength.enabled = false;
                afterGV.Stop();
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animatorForMovement.SetTrigger("Space Let Go");
        }
    }
    
    
    
    IEnumerator turnPowerUpOff()
    {
        yield return new WaitForSeconds(6);
        afterGV.Stop();
        defense.enabled = false;
        strength.enabled = false;
    }
}
