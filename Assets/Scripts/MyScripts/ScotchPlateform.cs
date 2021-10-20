using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScotchPlateform : MonoBehaviour
{
    //Si notre joueur touche cette plateform, il deviendra automatiquement son "enfant" et donc la suivra partout
    void OnCollisionEnter2D(Collision2D truc)
    {
        if (truc.gameObject.tag == "Player")
        {
            truc.transform.parent = transform;
        }
    }

    //Si notre joueur quitte cette plateform, il arr�tera d'�tre son "enfant" et donc ne bougera plus avec la plateforme
    void OnCollisionExit2D(Collision2D truc)
    {
        if (truc.gameObject.tag == "Player")
        {
            truc.transform.parent = null;
        }
    }
}
