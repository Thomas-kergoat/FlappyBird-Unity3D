using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // paramètre du point de spawn
    public float maxTime = 10;
    public float Timer = 0;
    public GameObject tuyau;
    public float hauteur;

    // Start is called before the first frame update
    void Start()
    {
        //on instanci le gameobject tuyau
        GameObject NouveauTuyau = Instantiate(tuyau);
        //on défini son point de spawn (sauf Y qui est un ramdom entre -hauteur et +hauteur)
        NouveauTuyau.transform.position = transform.position + new Vector3(5, Random.Range(-hauteur, hauteur), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //pour chaque moment ou Timer > maxTime on instanciera un nouveau tuyau avec un point de spawn similaire (sauf Y)
        if (Timer > maxTime)
        {
            GameObject NouveauTuyau = Instantiate(tuyau);
            NouveauTuyau.transform.position = transform.position + new Vector3(5, Random.Range(-hauteur, hauteur), 0);
            // on redéfinie Time a 0 pour pouvoir recréer un nouveau tuyau si flappy n'est pas mort
            Timer = 0;
        }

        Timer += Time.deltaTime;

    }
}
