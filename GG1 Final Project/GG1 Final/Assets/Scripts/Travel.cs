using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Travel : MonoBehaviour {

    public int lvlIndex;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            SceneManager.LoadScene(lvlIndex);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(lvlIndex);
    }
}
