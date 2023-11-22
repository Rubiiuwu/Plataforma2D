using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance{get; private set;}
    [SerializeField]public AudioClip playerDeath;
    [SerializeField]public AudioClip playerJump;
    [SerializeField]public AudioClip playerHurt;
    [SerializeField]public AudioClip starPick;
    [SerializeField]public AudioClip bombExplode;
    [SerializeField]public AudioClip bandaSonora;
    public AudioSource _sfxAudioSource;

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

        DontDestroyOnLoad(this.gameObject);
        _sfxAudioSource = GetComponent<AudioSource>();
    }

    public void PlayerDeath()
    {
    _sfxAudioSource.PlayOneShot(playerDeath);
    }
    public void PlayerJump()
    {
    _sfxAudioSource.PlayOneShot(playerJump);
    }

    public void PlayerHurt()
    {
    _sfxAudioSource.PlayOneShot(playerHurt);
    }
    public void StarPick()
    {
    _sfxAudioSource.PlayOneShot(starPick);
    }
    public void BombExplode()
    {
    _sfxAudioSource.PlayOneShot(bombExplode);
    }
    public void BandaSonora()
    {
    _sfxAudioSource.PlayOneShot(bandaSonora);
    }
}

