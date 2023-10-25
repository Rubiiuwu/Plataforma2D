using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance{get; private set;}
    [SerializeField]public AudioClip playerDeath;
    [SerializeField]public AudioClip playerJump;
    AudioSource _sfxAudioSource;

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy (this.gameObject);
        }
        else
        {
            instance = this;
        }
        _sfxAudioSource = GetComponent <AudioSource>();
    }

    public void PlayerDeath()
    {
    _sfxAudioSource.PlayOneShot(playerDeath);
    }
    public void PlayerJump()
    {
    _sfxAudioSource.PlayOneShot(playerJump);
    }
}