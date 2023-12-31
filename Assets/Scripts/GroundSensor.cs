using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool _isGrounded;
    private Animator _animator;

    void Start()
    {
      _animator = GameObject.Find("rogue").GetComponent<Animator>();
      //Esta función sirve para buscar en el "gameobject" (rogue) el componente animator
    }

    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.layer == 6)
        {
          _isGrounded = true;   
          _animator.SetBool("IsJumping", false); 
        }

        else if(other.gameObject.layer == 7)
       {
        Debug.Log("star!!");
        //SFXManager.EnemyDeath();
        Star star = other.gameObject.GetComponent<Star> ();
        star.Destroy();
       }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
          _isGrounded = false;
          _animator.SetBool("IsJumping", true);   
        }
    }
    
    void OnTriggerStay2D(Collider2D other) 
    {
        if(other.gameObject.layer == 6)
        {
          _isGrounded = true;   
          _animator.SetBool("IsJumping", false); 
        }
    }
}
