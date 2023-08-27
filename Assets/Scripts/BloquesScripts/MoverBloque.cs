using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAllDirections : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento del objeto

    private Vector3 initialPosition; // Posici�n inicial del objeto
    private Vector3 targetPosition; // Posici�n hacia la que se mover� el objeto
    private bool isMoving = false; // Variable para controlar si el objeto est� en movimiento

    private void Start()
    {
        initialPosition = transform.position; // Almacenar la posici�n inicial del objeto
    }

    private void Update()
    {
        // Si el objeto est� en movimiento
        if (isMoving)
        {
            // Mover el objeto hacia la posici�n objetivo
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Si el objeto llega a la posici�n objetivo, detener el movimiento
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
            // Calcular una posici�n aleatoria a la que mover el objeto
            float randomX = Random.Range(-5f, 5f); // Valor aleatorio en el rango -5 a 5
            float randomY = Random.Range(-5f, 5f); // Valor aleatorio en el rango -5 a 5
            targetPosition = new Vector3(initialPosition.x + randomX, initialPosition.y + randomY, initialPosition.z);

            isMoving = true; // Iniciar el movimiento del objeto
 �������}
    }
}