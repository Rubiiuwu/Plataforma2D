using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    BoxCollider2D boxCollider;
    SoundManager soundManager;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
       
    public void Destroy()
    {
      
        boxCollider.enabled = false;
        Destroy(this.gameObject);
        soundManager.StarPick();

    }
}
