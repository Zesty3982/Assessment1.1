using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{

    public GameObject sphere;

    private void OnTriggerEnter(Collider other)
    {
        sphere.GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one * 2f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one;
            sphere.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
