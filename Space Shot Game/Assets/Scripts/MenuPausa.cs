using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    private bool isPaused;
    public GameObject menuPausa;
    public AudioSource musica;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        menuPausa.SetActive(true);
        musica.Pause();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        menuPausa.SetActive(false);
        musica.Play();
    }
}
