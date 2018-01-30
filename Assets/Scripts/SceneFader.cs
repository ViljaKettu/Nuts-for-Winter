//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneFader : MonoBehaviour
{
    public void LoadNextLevel(string name)
    {
        StartCoroutine(LevelLoad(name));
    }

    //load level after one sceond delay
    public IEnumerator LevelLoad(string name)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Menu");
    }
}

