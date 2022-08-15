using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    private AudioSource bgMusic;
    private PlayerController playercontrollerscript;
    void Start()
    {
        playercontrollerscript = GameObject.Find("Player").GetComponent<PlayerController>();
        bgMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playercontrollerscript.gameOver)
        {
            bgMusic.Stop();
        }
    }
}
