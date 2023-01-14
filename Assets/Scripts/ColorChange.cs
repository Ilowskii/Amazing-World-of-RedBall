using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material Blue;
    public Material Green;
    public Material Pink;
    public Material Gold;
    public Material Red;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            GetComponent<Renderer>().material = Blue;
        }
        if (other.gameObject.CompareTag("Green"))
        {
            GetComponent<Renderer>().material = Green;
        }
        if (other.gameObject.CompareTag("Pink"))
        {
            GetComponent<Renderer>().material = Pink;
        }
        if (other.gameObject.CompareTag("Gold"))
        {
            GetComponent<Renderer>().material = Gold;
        }
        if (other.gameObject.CompareTag("Red"))
        {
            GetComponent<Renderer>().material = Red;
        }
    }
}
