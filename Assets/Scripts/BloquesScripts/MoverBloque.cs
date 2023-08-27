using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAllDirections : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento del objeto

    private Vector3 initialPosition; // Posición inicial del objeto
    private Vector3 targetPosition; // Posición hacia la que se moverá el objeto
    private bool isMoving = false; // Variable para controlar si el objeto está en movimiento

    private void Start()
    {
        initialPosition = transform.position; // Almacenar la posición inicial del objeto
    }

    private void Update()
    {
        // Si el objeto está en movimiento
        if (isMoving)
        {
            // Mover el objeto hacia la posición objetivo
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Si el objeto llega a la posición objetivo, detener el movimiento
            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    // Detectar colisiones con el jugador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Calcular una posición aleatoria a la que mover el objeto
            float randomX = Random.Range(-5f, 5f); // Valor aleatorio en el rango -5 a 5
            float randomY = Random.Range(-5f, 5f); // Valor aleatorio en el rango -5 a 5
            targetPosition = new Vector3(initialPosition.x + randomX, initialPosition.y + randomY, initialPosition.z);

            isMoving = true; // Iniciar el movimiento del objeto
        }
    }
}