using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            if (!hasCrashed)
            {
                hasCrashed = true;
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
            }

            Invoke("delayScene", delayTime);
        }
    }

    void delayScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Ou hit my head");
    }
}
