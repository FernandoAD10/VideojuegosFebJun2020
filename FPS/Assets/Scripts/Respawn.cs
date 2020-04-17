using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject parent, player;
    public Life LifeCode;
    public Transform R1, R2, R3, R4;
    GameObject child;

    // Update is called once per frame
    void Update()
    {
        //Si la vida llega a 0 entonces...
        if (LifeCode.life == 0)
        {
            //Se destruye al jugador
            Destroy(player);
            //Cuando el jugador aprieta alguna tecla se genera un nuevo player y lo manda a la posición (R1, R2, R3, R4)
            if (Input.GetKey(KeyCode.R))
            {
                //Activa el componente parent 
                parent.SetActive(true);
                //Se crea un nuevo hijo con las caracteristicas del parent en la posición de R1
                child = Instantiate(parent, new Vector3(R1.position.x, R1.position.y, R1.position.z), Quaternion.identity);
                //Se asigna al jugador el nuevo gameObject.
                player = child;
                //Se realiza el cambio de la referencia de la variable de vida del jugador (se toma de referencia la del hijo)
                LifeCode = child.GetComponent<Life>();
                //Se vuelve a desactivar el parent evitando que se manejen al mismo tiempo parent y child
                parent.SetActive(false);
            }

            if (Input.GetKey(KeyCode.T))
            {
                parent.SetActive(true);
                child = Instantiate(parent, new Vector3(R2.position.x, R2.position.y, R2.position.z), Quaternion.identity);
                player = child;
                LifeCode = child.GetComponent<Life>();
                parent.SetActive(false);
            }

            if (Input.GetKey(KeyCode.Y))
            {
                parent.SetActive(true);
                child = Instantiate(parent, new Vector3(R3.position.x, R3.position.y, R3.position.z), Quaternion.identity);
                player = child;
                LifeCode = child.GetComponent<Life>();
                parent.SetActive(false);
            }

            if (Input.GetKey(KeyCode.U))
            {
                parent.SetActive(true);
                child = Instantiate(parent, new Vector3(R4.position.x, R4.position.y, R4.position.z), Quaternion.identity);
                player = child;
                LifeCode = child.GetComponent<Life>();
                parent.SetActive(false);
            }
        }
    }
}