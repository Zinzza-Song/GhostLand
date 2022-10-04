using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestWin : MonoBehaviour
{
    public Button btnReplay;
    public Animation anim;

    private int score;

    public void Init(int score)
    {
        this.score = score;
    }

    public void Play()
    {
        //this.anim.Play()
    }
}
