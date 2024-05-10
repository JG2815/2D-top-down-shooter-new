using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllcator : MonoBehaviour
{
    [SerializeField]
    private int _killScore;

    private ScoreController _scoreController;

    private void Awake()
    {
        _scoreController = FindAnyObjectByType<ScoreController>();
    }

    public void AllocateScore()
    {
        _scoreController.AddScore(_killScore);
    }
}
