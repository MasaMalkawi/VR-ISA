using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance {get; private set;}

    private void Awake() 
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void OnClickChangeScene(string sceneName)
    {
        StartCoroutine(LoadYourAsyncScene(sceneName));
        
    }

    IEnumerator LoadYourAsyncScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            // u can a loading screen that stays active here
            yield return null;
        }
    }
    
}
