using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;
    [SerializeField] private AudioSource efectoSonido;


    //[SerializeField] private ControladorFaltantes faltantes;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            //faltantes.actualizarFaltantes();
            efectoSonido.Play();
            Destroy(gameObject);
        }
    }
}
