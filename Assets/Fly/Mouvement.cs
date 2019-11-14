using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    //variable pour la vitesse des tuyaux
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //déplacement des tuyaux en fonction de leur vitesse
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
