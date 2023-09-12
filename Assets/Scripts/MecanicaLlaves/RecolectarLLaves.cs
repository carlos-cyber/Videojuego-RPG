using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarLlaves : MonoBehaviour
{

    [Header("Dependencies")]
    [SerializeField] private Controlador controlador;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            controlador.completarLlave();
        }
    }

}