using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{

    public AnimatorOverrideController Bird2;
    public AnimatorOverrideController Bird3;
    public AnimatorOverrideController Bird4;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void BirdSkin2()
    {
        GetComponent<Animator>().runtimeAnimatorController = Bird2 as RuntimeAnimatorController;
    }

    public void BirdSkin3()
    {
        GetComponent<Animator>().runtimeAnimatorController = Bird3 as RuntimeAnimatorController;
    }

    public void BirdSkin4()
    {
        GetComponent<Animator>().runtimeAnimatorController = Bird4 as RuntimeAnimatorController;
    }

}
