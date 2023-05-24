using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Continue()
    {
        int levelToLoad= PlayerPrefs.GetInt("DernierNiveau");

        if(levelToLoad>1)
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
