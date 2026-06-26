using UnityEngine;
using UnityEngine.SceneManagement;
public class BattonScript : MonoBehaviour
{

    public void loadScen (int index)
    {
        SceneManager.LoadScene (index);
    }

}