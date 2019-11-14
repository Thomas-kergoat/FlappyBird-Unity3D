using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{

    // pour chaque collision avec un Boxcollider (IsTrigger) le score du joueur augmente de 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }

}
