using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioClip activatedSound;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(activatedSound, transform.position, 1);
    }
}
