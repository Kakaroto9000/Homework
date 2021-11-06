using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void TaskOnClick()
    {
        SceneManager.LoadScene("main");
    }
}