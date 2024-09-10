using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip shootSound;
    public AudioClip explosionSound;
    private AudioSource audioSource;

    private void Awake()
    {
        // Implementa el patrón Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruir al cambiar de escena
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Método para reproducir efectos de sonido
    public void PlaySound(string soundName)
    {
        switch (soundName)
        {
            case "shoot":
                audioSource.PlayOneShot(shootSound);
                break;
            case "explosion":
                audioSource.PlayOneShot(explosionSound);
                break;
            default:
                Debug.LogWarning("Sonido no encontrado");
                break;
        }
    }

    // Método para detener todos los sonidos
    public void StopSound()
    {
        audioSource.Stop();
    }
}
