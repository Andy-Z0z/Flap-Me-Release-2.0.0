using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{ 
    public void SwitchScene(int num)
    {
        SceneManager.LoadScene(num);
    }

}