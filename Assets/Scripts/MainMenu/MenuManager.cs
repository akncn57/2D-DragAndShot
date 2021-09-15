using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    public GameObject Ball;
    public GameObject MainMenuUI;
    public GameObject LevelsUI;
    public GameObject SettingsUI;

    public void PlayButton()
    {
        // StartGame function.
        StartCoroutine(StartGame());
    }

    public void LevelsButton()
    {
        StartCoroutine(LevelsUIAnimation());
    }

    public void SettingsButton()
    {
        StartCoroutine(SettingsUIAnimation());
    }

    public void ExitButton()
    {
        // Exit game.
        Application.Quit();
    }

    public void BackButton()
    {
        StartCoroutine(BackButtonAnimation());
    }

    IEnumerator StartGame()
    {
        // MainMenuUI alpha value 0.
        MainMenuUI.GetComponent<CanvasGroup>().DOFade(0f, 1f);

        yield return new WaitForSeconds(1);

        // Load game level scene.
        SceneManager.LoadScene("1");
    }

    IEnumerator LevelsUIAnimation()
    {
        // Ball alpha value 0.
        Ball.GetComponent<SpriteRenderer>().DOFade(0f, 0.65f);

        // MainMenuUI alpha value 0.
        MainMenuUI.GetComponent<CanvasGroup>().DOFade(0f, 0.5f);

        yield return new WaitForSeconds(0.50f);

        // MainMenuUI disable.
        MainMenuUI.SetActive(false);

        // LevelsUI active.
        LevelsUI.SetActive(true);

        // LevelsUI alpha value 0.
        LevelsUI.GetComponent<CanvasGroup>().DOFade(1f, 0.75f);
    }

    IEnumerator SettingsUIAnimation()
    {
        // Ball alpha value 0.
        Ball.GetComponent<SpriteRenderer>().DOFade(0f, 0.65f);

        // MainMenuUI alpha value 0.
        MainMenuUI.GetComponent<CanvasGroup>().DOFade(0f, 0.5f);

        yield return new WaitForSeconds(0.50f);

        // MainMenuUI disable.
        MainMenuUI.SetActive(false);

        // SettingsUI active.
        SettingsUI.SetActive(true);

        // SettingsUI alpha value 0.
        SettingsUI.GetComponent<CanvasGroup>().DOFade(1f, 0.75f);
    }

    IEnumerator BackButtonAnimation()
    {
        // LevelsUI disable.
        LevelsUI.SetActive(false);

        // SettingsUI disable.
        SettingsUI.SetActive(false);

        yield return new WaitForSeconds(0.20f);

        // MainMenuUI disable.
        MainMenuUI.SetActive(true);

        // Ball alpha value 1.
        Ball.GetComponent<SpriteRenderer>().DOFade(1f, 0.65f);

        // MainMenuUI alpha value 0.
        MainMenuUI.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
    }

    public void Level1Button()
    {
        SceneManager.LoadScene("1");
    }

    public void Level2Button()
    {
        SceneManager.LoadScene("2");
    }

    public void Level3Button()
    {
        SceneManager.LoadScene("3");
    }

    public void Level4Button()
    {
        SceneManager.LoadScene("4");
    }

    public void Level5Button()
    {
        SceneManager.LoadScene("5");
    }

    public void Level6Button()
    {
        SceneManager.LoadScene("6");
    }
}
