using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int points = 0;
    public int pointsToWin = 10;

    void Update()
    {
        // Simula ganar puntos
        if (Input.GetKeyDown(KeyCode.P))
        {
            points++;
            CheckWinCondition();
        }
    }

    void CheckWinCondition()
    {
        if (points >= pointsToWin)
        {
            Debug.Log("¡Nivel completado!");
            SoundManager.instance.PlaySound("explosion");
            // Aquí puedes cargar otro nivel si quieres
        }
    }
}
