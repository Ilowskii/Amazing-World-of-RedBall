using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDialog : MonoBehaviour
{
    public GameObject Dia1;
    public GameObject Dia2;
    public GameObject Dia3;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dialog1"))
        {
            Dia1.SetActive(true);
        }
        if (other.gameObject.CompareTag("Dialog2"))
        {
            Dia2.SetActive(true);
        }
        if (other.gameObject.CompareTag("Dialog3"))
        {
            Dia3.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Dialog1"))
        {
            Dia1.SetActive(false);
        }
        if (other.gameObject.CompareTag("Dialog2"))
        {
            Dia2.SetActive(false);
        }
        if (other.gameObject.CompareTag("Dialog3"))
        {
            Dia3.SetActive(false);
        }
    }
}
