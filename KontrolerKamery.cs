using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.Collections.Generic;

public class KontrolerKamery : MonoBehaviour
{
    public float predkoscObrotu = 5f;
    public float ograniczeniePoziome = 120f; //Poziome
    public float ograniczeniePionowe = 80f;

    void Update()
    {
        float wejsciePoziome = Input.GetAxis("Horizontal");
        float wejsciePionowe = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, wejsciePoziome * predkoscObrotu * Time.deltaTime);
        transform.Rotate(Vector3.left, wejsciePionowe * predkoscObrotu * Time.deltaTime);

        Vector3 aktualnyObrot = transform.eulerAngles;
        aktualnyObrot.x = Mathf.Clamp(aktualnyObrot.x, 0f, ograniczeniePionowe);
        aktualnyObrot.y = Mathf.Clamp(aktualnyObrot.y, 0f, ograniczeniePoziome); //Poziome
        transform.eulerAngles = aktualnyObrot;
    }
}
