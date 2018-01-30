//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Load first level
    public void OnClickPlay()
    {
        SceneManager.LoadScene("testi");
    }

    //Quiting game
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    //Use to load scene by giving name in unity inspector
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

}

