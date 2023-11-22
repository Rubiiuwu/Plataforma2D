using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    CircleCollider2D circleCollider;
    SoundManager soundManager;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        circleCollider = GetComponent<CircleCollider2D>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
       
    public void Destroy()
    {
      
        circleCollider.enabled = false;
        Destroy(this.gameObject);
        soundManager.BombExplode();

    }
}
