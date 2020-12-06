using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ShootingGallery()
    {
        SceneManager.LoadScene("Shooting Gallery");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");

    }
}
