using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //variable pour le score
    public static int score = 0;

    private void Start()
    {
        //démarrage le score est a 0
        score = 0;
    }

    private void Update()
    {
        //permet de mettre a jour le text qui affiche le score.
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
