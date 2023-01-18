using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProceed : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainHub"))
        {
            SceneManager.LoadScene(0);

        }
        if (other.gameObject.CompareTag("Levels"))
        {
            SceneManager.LoadScene(1);
            
        }       
        if (other.gameObject.CompareTag("Bonus"))
        {
            SceneManager.LoadScene(2);

        }
        if (other.gameObject.CompareTag("Level1"))
        {
            SceneManager.LoadScene(3);

        }
        if (other.gameObject.CompareTag("Level2"))
        {
            SceneManager.LoadScene(4);

        }
        if (other.gameObject.CompareTag("Level3"))
        {
            SceneManager.LoadScene(5);

        }        
        if (other.gameObject.CompareTag("Quit"))
        {
            Application.Quit();
            Debug.Log("Oyunu Kapattýn");
        }
    }
}
