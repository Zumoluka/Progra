using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Simula disparo
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Llama al SoundManager para reproducir el sonido de disparo
        SoundManager.instance.PlaySound("shoot");
        Debug.Log("Disparo ejecutado");
    }
}
