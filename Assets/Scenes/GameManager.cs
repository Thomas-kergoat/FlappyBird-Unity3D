using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //on récupére le Canvas gameover que l'on ajoute dans la variable gameOverCanvas
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //n'affiche pas le canvas game over
        gameOverCanvas.SetActive(false);

    }

    //cette fonction permet d'afficher le canvas
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);

    }

    //cette fonction permet de reload le jeu et de pouvoir refaire une partie.
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
