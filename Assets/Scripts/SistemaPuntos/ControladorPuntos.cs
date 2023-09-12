using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;
    [SerializeField] private int cantidadPuntos;


    private void Awake()
    {
        if (ControladorPuntos.Instance == null)
        {
            ControladorPuntos.Instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SumarPuntos(int puntos)
    {
        cantidadPuntos += puntos;
    }
    public int ReturnPuntos()
    {
        return cantidadPuntos;
    }
    public void Reset()
    {
        cantidadPuntos = 0;
    }
}
