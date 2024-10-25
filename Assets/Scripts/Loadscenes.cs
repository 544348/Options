using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscenes : MonoBehaviour
{
    // Public variable to specify the scene name in the Inspector
    public string sceneToLoad;

    // This method can be assigned to a button's OnClick event
    public void LoadScene()
    {
        // Check if the scene name is not empty
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Scene name is not set!");
        }
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("application quit");
    }
}
