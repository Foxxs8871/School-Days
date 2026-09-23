using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject CreditImage;
    public void Play()
    {
            SceneManager.LoadScene("SampleScene");
    }

    public void Credit()
    {
        CreditImage.SetActive(true);
    }

    public void Back()
    {
        CreditImage.SetActive(false);
    }

    public void Quit()
    {
            Application.Quit();
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
    }
}
