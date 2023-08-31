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
    private void Start()
    {
        count = CountElementsWithTag(tagToCount);
    }

    private void Update()
    {
        if (completed == count)
        {
            objeto.SetActive(true);
        }
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