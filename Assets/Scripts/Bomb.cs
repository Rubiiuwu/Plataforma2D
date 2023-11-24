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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy();
            GameManager.instance.PerderVida;
        }
    }
       
    public void Destroy()
    {
        circleCollider.enabled = false;
        soundManager.BombExplode();
        anim.SetBool("Bomb explode", true);
    }

    void DestroyBomb()
    {
        Destroy(this.gameObject);
    }
}
