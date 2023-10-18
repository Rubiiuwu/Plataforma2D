using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

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
    //private GroundSensor _sensor;
    [SerializeField] private Animator _animator;
    [SerializeField] private PlayableDirector _director;
    
    
    void Start()
    {
        _rBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement ();

       if(Input.GetButtonDown("Jump") && GroundSensor._isGrounded)
       {
        Playerjump();
       }

       _animator.SetBool("IsJumping", GroundSensor._isGrounded);
       
       if(Input.GetButtonDown("Fire2"))
       {
        _director.Play();
       }
       
    }
    
    void FixedUpdate() 
    {
        /*_rBody2D.AddForce(new Vector2(_playerInputHorizontal * _playerSpeed, 0), ForceMode2D.Impulse);
        esta línea se utilizará para hacer el salto ;) */
        _rBody2D.velocity = new Vector2(_playerInputHorizontal * _playerSpeed, _rBody2D.velocity.y);
    }
    
    void PlayerMovement()
    {
        _playerInputHorizontal = Input.GetAxis("Horizontal");
        /*_playerInputVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(_playerInputHorizontal, _playerInputVertical) * _playerSpeed * Time.deltaTime);*/
        
        if(_playerInputHorizontal < 0)
        {
        transform.rotation = Quaternion.Euler(0, 180, 0);
        _animator.SetBool("IsRunning", true);
        }

        if(_playerInputHorizontal > 0)
        {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _animator.SetBool("IsRunning", true);
        }

        if(_playerInputHorizontal == 0)
        {
        _animator.SetBool("IsRunning", false);
        }

    }

    void Playerjump()
    {
        _rBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);  
        /*if = condicionante
       _rBody2D porque en los "()" indicas como hay 2 vertices zy y xy, y como solo afecta el jumpforce al xy*/
    }

    public void SignalTest()
    {
        Debug.Log("Señal recibida");
    }

}

