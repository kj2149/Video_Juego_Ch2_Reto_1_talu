using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int Puntaje = 0;
    public TMP_Text scoreT;
    public GameObject caliz;
    public GameObject puerta;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
           
            Puntaje++;
            scoreT.text = " Score " + Puntaje;


        }

        if ( Puntaje == 147 )

        {
            puerta.SetActive(false);

        }

        if (Puntaje == 290)

        {
            caliz.SetActive(true);

        }



    }


}
