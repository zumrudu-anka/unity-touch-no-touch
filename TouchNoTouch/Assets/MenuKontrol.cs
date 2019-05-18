using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    public void oyunagit()
    {
        SceneManager.LoadScene("Oyun");
    }

    public void oyundancik()
    {
        Application.Quit();
    }
}
