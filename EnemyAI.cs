using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public Transform target; //player
    public float moveSpeed = 5f;
    public float rotationSpeed = 2f;
    private bool isChasing = false; //czyGoni

    void Update()
    {
        if (isChasing)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isChasing = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) //Player tag na graczu
        {
            isChasing = false;
        }
    }
}