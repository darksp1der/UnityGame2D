using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllScenesAudio : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
    }
}
