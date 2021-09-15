using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class PlayerManager : MonoBehaviour
{
    public GameObject FinishParticleEffect;
    public GameObject NextLevelUI;
    public GameObject GameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Player hit finish object.
        if (collision.tag == "FinishObject")
        {
            // Finish effect.
            Instantiate(FinishParticleEffect, transform.position, transform.rotation);

            // Destroy player object.
            Destroy(this.gameObject);

            // NextLevelUI active.
            NextLevelUI.SetActive(true);

            // NextLevelUI animation.
            NextLevelUI.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
        }

        // Player hit fall limit.
        if (collision.tag == "FallLimit")
        {
            // Destroy player object.
            Destroy(this.gameObject);

            // GameOverUI active.
            GameOverUI.SetActive(true);

            // GameOverUI animation.
            GameOverUI.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
        }

        // Plaer hit danger platform.
        if (collision.tag == "DangerPlatform")
        {
            // Destroy player object.
            Destroy(this.gameObject);

            // GameOverUI active.
            GameOverUI.SetActive(true);

            // GameOverUI animation.
            GameOverUI.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
        }

    }

    
}
