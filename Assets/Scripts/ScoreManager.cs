using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public ThirdPersonController player;
    private int score = 0;
    public TextMeshPro scoreHold;
    void Start()
    {
    }
    void Update()
    {
        scoreHold.text = player.totalScore.ToString();
    }

}
