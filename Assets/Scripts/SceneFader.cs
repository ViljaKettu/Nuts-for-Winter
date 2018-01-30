//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


//Ei toimi


public class SceneFader : MonoBehaviour
{
    public Image fadeOutImageUI;
    public float fadeSpeed = 0.3f;

    public enum FadeDirection
    {
        In, Out
    }

    void OnEnable()
    {
        StartCoroutine(Fade(FadeDirection.Out));
    }

    IEnumerator Fade(FadeDirection direction)
    {
        float alpha = (direction == FadeDirection.Out) ? 1 : 0;
        float fadeEndFalue = (direction == FadeDirection.Out) ? 0 : 1;

        if (direction == FadeDirection.Out)
        {
            while(alpha >= fadeEndFalue)
            {
                SetColorImage(ref alpha, direction);
                yield return null;
            }
            fadeOutImageUI.enabled = false;
        }
        else
        {
            fadeOutImageUI.enabled = true;

            while (alpha <= fadeEndFalue)
            {
                SetColorImage(ref alpha, direction);
                yield return null;
            }
        }

    }

    public IEnumerator FadeAndLoadScene(FadeDirection direction, string sceneToLoad)
    {
        yield return Fade(direction);
        SceneManager.LoadScene(sceneToLoad);
    }

    private void SetColorImage(ref float alpha, FadeDirection direction)
    {
        fadeOutImageUI.color = new Color(fadeOutImageUI.color.r, fadeOutImageUI.color.g, fadeOutImageUI.color.b, alpha);
        alpha += Time.deltaTime * (1.0f / fadeSpeed) * ((direction == FadeDirection.Out) ? -1 : 1);
    }
}

