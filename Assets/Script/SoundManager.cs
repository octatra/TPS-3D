using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip uiButton;

    private AudioSource audio;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)

            Destroy(gameObject);
        else
            instance = this;

        audio = GetComponent<AudioSource>();

    }

    public void UIClickSfx()
    {
        audio.PlayOneShot(uiButton);
    }

}
