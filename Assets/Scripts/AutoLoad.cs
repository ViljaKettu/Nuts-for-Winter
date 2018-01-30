//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoad : MonoBehaviour
{
    //Loads scene after delay

    void Awake()
    {
        StartCoroutine(Wait());
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }
}
