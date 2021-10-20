using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesFall : MonoBehaviour
{

    // Ce script permet de faire tomber une plateforme apr�s un certain temps quand le joueur marche dessus

    public float wait = 1f;     // Le temps que la plateforme va mettre pour tomber
    private Rigidbody2D rb;     // Le rigidbody du piques

    // Si le joueur touche la plateforme, on lance la coroutine "haaaaa"
    void OnCollisionEnter2D(Collision2D truc)
    {
        if (truc.gameObject.tag == "Player")
        {
            StartCoroutine(incoming());
        }
    }

    // Dans cette coroutine on fait dans l'ordre : 
    // 1/ Attendre (le temps d�fini dans "wait") 2/ On ajoute un rigidbody pour le faire tomber 3/ On d�sactive le collider pour pas qu'il nous g�ne 4/ On d�truit l'objet apr�s 1 seconde
    IEnumerator incoming()
    {
        yield return new WaitForSeconds(wait);
        gameObject.AddComponent<Rigidbody2D>();
        gameObject.GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 1f);
    }
}
