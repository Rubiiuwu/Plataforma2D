using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float _playerSpeed = 5;
    //los corchetes estos " [] " son para que se vea en el inspector
     
    private float _playerInput;
    private float _playerInputVertical;
    private float _playerInputHorizontal;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement ();


        //_playerInputHorizontal = Input.GetAxis("Horizontal");
        //_playerInputVertical = Input.GetAxis("Vertical");
        //transform.Translate(new Vector2(_playerInputHorizontal, _playerInputVertical) * _playerSpeed * Time.deltaTime);

                   //lo de arriba y a bajo es lo mismo :)

       // _playerInput = Input.GetAxis("Horizontal");
       //transform.Translate(new Vector2(_playerInput, 0f) * _playerSpeed * Time.deltaTime);
       // _playerInput = Input.GetAxis("Vertical");
       //transform.Translate(new Vector2(0f, _playerInput) * _playerSpeed * Time.deltaTime);
    }
    
        void PlayerMovement()
        {
        _playerInputHorizontal = Input.GetAxis("Horizontal");
        _playerInputVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(_playerInputHorizontal, _playerInputVertical) * _playerSpeed * Time.deltaTime);
        }

}
