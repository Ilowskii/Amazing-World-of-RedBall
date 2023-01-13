using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProceed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainHub")
        {
            SceneManager.LoadScene(1);
        }
    }


}
