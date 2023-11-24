using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{

    public TextMeshProUGUI puntos;
    public GameObject[] vidas;

    void Puntos(int puntosTotales)
    {
       // puntos.text = puntosTotales.ToSring();
    }

    void ActivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }

    void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
