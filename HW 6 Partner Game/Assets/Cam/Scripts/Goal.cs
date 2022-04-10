using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Got me!");
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
