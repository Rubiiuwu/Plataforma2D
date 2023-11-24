using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get; private set;}
    public int vidas = 3;
    public HUD hud;

    
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
    public void Play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene(1);
    }

    public void PerderVida()
    {
        vidas = -1;
        if(vidas == 0)
        {
            SoundManager.instance.PlayerDeath();
            SceneManager.LoadScene(2);
        }
        hud.DesactivarVida(vidas);
    }
}
