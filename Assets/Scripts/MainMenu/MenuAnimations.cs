using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuAnimations : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Logo;
    public GameObject PlayButton;
    public GameObject LevelsButton;
    public GameObject SettingsButton;
    public GameObject ExitButton;
    public GameObject InfoText;

    private void Start()
    {
        // Ball start fade animation.
        Ball.GetComponent<SpriteRenderer>().DOFade(1f, 1f);

        // Main Menu animations.
        MainMenuAnimation();
    }

    public void MainMenuAnimation()
    {
        Logo.GetComponent<CanvasGroup>().DOFade(1f, 2f);
        PlayButton.GetComponent<CanvasGroup>().DOFade(1f, 2f);
        LevelsButton.GetComponent<CanvasGroup>().DOFade(1f, 2f);
        SettingsButton.GetComponent<CanvasGroup>().DOFade(1f, 2f);
        ExitButton.GetComponent<CanvasGroup>().DOFade(1f, 2f);
        InfoText.GetComponent<CanvasGroup>().DOFade(1f, 2f);
    }
}
