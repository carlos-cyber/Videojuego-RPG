using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAllDirections : MonoBehaviour
{
    public float forceMagnitude = 0.5f; // Magnitud de la fuerza aplicada
    private bool isMoving = false; // Variable para controlar si el objeto est� en movimiento
    private Rigidbody2D rb2d; // Referencia al Rigidbody2D del objeto

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // Obtener la referencia al Rigidbody2D
    }

    private void Update()
    {
        // Si el objeto est� en movimiento
        if (isMoving)
        {
            isMoving = false; // Detener el movimiento despu�s de un cuadro
        }
    }

    // Detectar colisiones con el jugador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Calcular la direcci�n de la colisi�n
            Vector2 collisionDirection = (transform.position - collision.transform.position).normalized;

            // Aplicar una fuerza en la direcci�n de la colisi�n
            rb2d.AddForce(collisionDirection * forceMagnitude, ForceMode2D.Impulse);

            isMoving = true; // Marcar que el objeto est� en movimiento
 �������}
    }
}