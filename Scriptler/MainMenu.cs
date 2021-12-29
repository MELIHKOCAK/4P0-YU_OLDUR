using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);       //bir çok seçenek var ben burada bir sonraki sahneyi başlatmasını isteyeceğim
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.LogWarning("Oyundan Çıkıldı!  +1 ve 0");
    }

    public void GeriDonAnaEkran()
    {
        SceneManager.LoadScene(0);
    }
}
