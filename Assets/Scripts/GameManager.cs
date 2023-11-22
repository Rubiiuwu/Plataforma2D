using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get; private set;}
    public int vidas;

    
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
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(2);
    }

}
