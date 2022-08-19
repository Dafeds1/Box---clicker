using UnityEngine;
using UnityEngine.SceneManagement;


public class TransistionScenes : MonoBehaviour
{
    [SerializeField]
    private string _nameScene;
    public void Transistion()
    {
        SceneManager.LoadScene(_nameScene, LoadSceneMode.Single);   
    }
}
