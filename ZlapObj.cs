using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.Collections.Generic;

public class ZlapObj : MonoBehaviour
{
    public TextMesh napisTextMesh;

    private Transform dlonTransform; //Holder dloni
    private bool czyPodniesiono = false;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !czyPodniesiono)
        {
            if (dlonTransform != null)
            {
                transform.position = dlonTransform.position;
                transform.rotation = dlonTransform.rotation;

                if (napisTextMesh != null)
                {
                    napisTextMesh.text = "Kliknij E by podnieść";
                    czyPodniesiono = true;
                }
            }
        }
    }
}