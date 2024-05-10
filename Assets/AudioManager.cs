using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header ("--------------- Audio Source -----------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------------- Audio Clip -----------------")]
    public AudioClip SongAffirmation;
    public AudioClip Hurt;
    public AudioClip Gun;
    public AudioClip Death;

    private void Start()
    {
        musicSource.clip = SongAffirmation;
        musicSource.Play();
    }


    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
