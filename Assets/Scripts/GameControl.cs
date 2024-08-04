using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeControl : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        // menüye dönmek
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        // Ses seviyesini ayarlamak
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetVolume(0.1f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetVolume(0.2f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetVolume(0.3f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetVolume(0.4f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetVolume(0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SetVolume(0.6f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SetVolume(0.7f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SetVolume(0.8f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SetVolume(1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SetVolume(0f); // sesi Kapat
        }
    }

    void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
