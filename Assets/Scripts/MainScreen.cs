using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    FadeInOut fade;
    void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
    }
    public void PlayGame()
    {
        StartCoroutine(_ChangeScene());
    }

    public IEnumerator _ChangeScene()
    {
        fade.FadeIn();

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        print("QUIT");
        Application.Quit();
    }
}
