using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D RB;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Faire sauter le Bird avec un bouton de souris
        if (Input.GetMouseButtonDown(0))
        {
            RB.velocity = Vector2.up * velocity;

        }

    }

    /*quand Flappy entrera en collision avec un obstacle 
    GameManager affichera le Canvas de GameOver*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crash de Flappy");
        //on appelle la fonction GameOver() du GameManager.
        gameManager.GameOver();
    }
}
