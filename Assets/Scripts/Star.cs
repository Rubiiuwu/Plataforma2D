using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    BoxCollider2D boxCollider;
    //SFX sfxManager;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        //sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
       
    public void Destroy()
    {
      
        boxCollider.enabled = false;
        Destroy(this.gameObject);
        //sfxManager.Coin();

    }
}
