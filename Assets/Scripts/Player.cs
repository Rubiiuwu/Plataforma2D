using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [Tooltip("Controla la velocidad d movimiento del personaje")]

    [SerializeField]private float _playerSpeed = 5;
    //los corchetes estos " [] " son para que se vea en el inspector
    [Tooltip("Controla la fuerza de salto del personaje")]
    [SerializeField]private float _jumpForce = 5;
     
    private float _playerInput;
    //private float _playerInputVertical;
    private float _playerInputHorizontal;
    private Rigidbody2D _rBody2D;
    private GroundSensor _sensor;
    private Animator _animator;
    
    void Start()
    {
        _rBody2D = GetComponent<Rigidbody2D>();
        _sensor = GetComponentInChildren<GroundSensor>();
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement ();

       if(Input.GetButtonDown("Jump") && _sensor._isGrounded)
       {
        Playerjump();
       //_rBody2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
       //if = condicionante
       //_rBody2D porque en los "()" indicas como hay 2 vertices zy y xy, y como solo afecta el jumpforce al xy
       }
    }
    
    void FixedUpdate() 
    {
        //_rBody2D.AddForce(new Vector2(_playerInputHorizontal * _playerSpeed, 0), ForceMode2D.Impulse);
        //esta línea se utilizará para hacer el salto ;)
        _rBody2D.velocity = new Vector2(_playerInputHorizontal * _playerSpeed, _rBody2D.velocity.y);
    }
    
    void PlayerMovement()
    {
        _playerInputHorizontal = Input.GetAxis("Horizontal");
        //_playerInputVertical = Input.GetAxis("Vertical");
        //transform.Translate(new Vector2(_playerInputHorizontal, _playerInputVertical) * _playerSpeed * Time.deltaTime);
        
        if(_playerInputHorizontal !=0)
        {
            _animator.SetBool("IsRunning", true);
        }

        if(_playerInputHorizontal ==0)
        {
            _animator.SetBool("IsRunning", false);
        }
    }

    void Playerjump()
    {
           _rBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);  
        //if = condicionante
       //_rBody2D porque en los "()" indicas como hay 2 vertices zy y xy, y como solo afecta el jumpforce al xy
    }

}

