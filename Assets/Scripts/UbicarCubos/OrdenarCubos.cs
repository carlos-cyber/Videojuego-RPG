using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class OrdenarCubos : MonoBehaviour
{
    [Header("Extra config")]
    public string validTag;

    [Header("Objects")]
    [SerializeField] GameObject objeto;
    public string tagToCount = "Obstaculo";

    [Header("Completados")]
    [SerializeField] public int completed = 0;
    public int count;
    [SerializeField] public AudioSource sonidoPuerta;
    [SerializeField] GameObject cerrado;
    [SerializeField] GameObject abierto;
    private void Start()
    {
        count = CountElementsWithTag(tagToCount);
    }

    private void Update()
    {
      
    }


    private int CountElementsWithTag(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        return taggedObjects.Length;
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(validTag))
        {
            completed++;

            if (completed == count)
            {
                objeto.SetActive(true);
                sonidoPuerta.Play();
                cerrado.SetActive(false);
                abierto.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(validTag))
        {
            if (completed > 0)
            {
                completed--;
            }
        }
    }

}