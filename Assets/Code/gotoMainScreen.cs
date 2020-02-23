//Borrowed from the internet, not made by us

using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Blank");
    }
}
