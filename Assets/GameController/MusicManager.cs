using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume = 1f;
    private static MusicManager musicManagerInstance;
    
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.volume = musicVolume;
        

    }

    
    void Update()
    {
        audioSrc.volume = musicVolume;
      

    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
        if(musicManagerInstance == null)
        {
            musicManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
