using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    public int life;

    private void OnTriggerEnter(Collider collisioner)
    {
        if (collisioner.gameObject.tag == "Borbotones")
        {
            life--;
        }

        Debug.Log(life);
    }
}
