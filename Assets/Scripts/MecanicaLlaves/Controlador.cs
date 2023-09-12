using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    [Header("Task Details")]
    [SerializeField] private int numeroLlaves;

    [Header("GameObjects")]
    [SerializeField] GameObject col;
    [SerializeField] GameObject abierto;
    [SerializeField] GameObject cerrado;
    [SerializeField] private AudioSource efectoSonido;

    public void completarLlave()
    {
        numeroLlaves--;
        if (numeroLlaves <= 0)
        {
            col.SetActive(true);
            efectoSonido.Play();
            cerrado.SetActive(false);
            abierto.SetActive(true);


        }

    }
}