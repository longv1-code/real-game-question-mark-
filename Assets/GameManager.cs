using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startingSceneTransition;
    [SerializeField] private GameObject _endingSceneTransition;

    private void Start()
    {
        _startingSceneTransition.SetActive(true);
        FunctionTimer.Create(DisableStartingSceneTransition, timer:5f);
    }

    private void DisableStartingSceneTransition()
    {
        _startingSceneTransition.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _endingSceneTransition.SetActive(true);
            FunctionTimer.Create(LoadNextLevel, timer:1.5f);
            
        }
    }

    private static void LoadNextLevel()
    {
        SceneManager.LoadScene("Game");
    }
}
