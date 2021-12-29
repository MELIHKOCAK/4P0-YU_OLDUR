using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadScene : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
        Debug.LogWarning("Oyundan Çıkıldı!  +1 ve 0");
    }

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GeriDonAnaEkran()
    {
        SceneManager.LoadScene(0);
    }
}
