using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioSource audioSourceSFX;
    public AudioClip[] musicasDeFundo;

    public AudioClip[] coinSounds;
    public AudioClip[] spottedSounds;
    public AudioClip[] fantasmaSounds;

    void Start()
    {
        int IndexDaMusicaDeFundo = Random.Range(0, musicasDeFundo.Length);
        AudioClip musicaDeFundoDessaFase = musicasDeFundo[IndexDaMusicaDeFundo];
        audioSourceMusicaDeFundo.clip = musicaDeFundoDessaFase;
        audioSourceMusicaDeFundo.loop = true;
        audioSourceMusicaDeFundo.Play();
    }

    public void ToqueSFX(AudioClip clip)
    {
        audioSourceSFX.PlayOneShot(clip);
    }
}
