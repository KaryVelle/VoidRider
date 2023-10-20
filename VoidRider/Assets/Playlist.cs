using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playlist : MonoBehaviour
{
    public AudioSource[] songs; 
    public Text songTitleText; 
    private int currentSongIndex = 0; 

    void Start()
    {
        PlayCurrentSong();
    }

    public void Play()
    {
        songs[currentSongIndex].Play();
    }

    public void Pause()
    {
        songs[currentSongIndex].Pause();
    }

    public void NextSong()
    {
        songs[currentSongIndex].Stop();
        currentSongIndex = (currentSongIndex + 1) % songs.Length;
        PlayCurrentSong();
    }

    private void PlayCurrentSong()
    {
        songTitleText.text = "Now Playing: Song " + (currentSongIndex + 1);
        if (currentSongIndex == songs.Length)
        {
            currentSongIndex = 0;
        }
        Play();
    }
}
