using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] Button ResumeBtn;
    [SerializeField] Button RestartBtn;
    [SerializeField] Button MainMenu;
    [SerializeField] Button AddButton;
    [SerializeField] UIManager uiManager;
    [SerializeField] LevelManager levelManager;

    private void Start()
    {
        ResumeBtn.onClick.AddListener(ResumeGame);
        RestartBtn.onClick.AddListener(RestartLevel);
        MainMenu.onClick.AddListener(BackToMainMenu);
        MainMenu.onClick.AddListener(ShowBannerAd);
    }

    private void BackToMainMenu()
    {
        levelManager.GoToMainMenu();
    }

    private void RestartLevel()
    {
        levelManager.RestartCurrentLevel();
    }

    private void ResumeGame()
    {
        uiManager.SwithToGameplayUI();
    }

    private void ShowBannerAd()
    {
        uiManager.SwithToGameplayUI();
    }


}
