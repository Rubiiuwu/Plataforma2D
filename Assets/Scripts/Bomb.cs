using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    CircleCollider2D circleCollider;
    //SFX sfxManager;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        circleCollider = GetComponent<CircleCollider2D>();
        //sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
       
    public void Destroy()
    {
      
        circleCollider.enabled = false;
        Destroy(this.gameObject);
        //sfxManager.Bomb();

    }
}
