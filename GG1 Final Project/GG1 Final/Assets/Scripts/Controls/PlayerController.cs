using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float spd;

    private Rigidbody2D rb;

    private Text hudText;

    private int sceneNum;
    
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        hudText = GameObject.FindGameObjectWithTag("HudText").GetComponent<Text>();
        sceneNum = SceneManager.GetActiveScene().buildIndex;
	}

    void Update()
    {
        GetLocation();
    }

    void FixedUpdate ()
    {
        float moveX = Input.GetAxis("Horizontal");

        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX * spd, moveY * spd);

        rb.velocity = movement;
	}

    void GetLocation()
    {
        switch (sceneNum)
        {
            case 1:
                hudText.text = "Forest Grove";
                break;
            case 2:
                hudText.text = "Woods";
                break;
            case 3:
                hudText.text = "Countryside";
                break;
            case 4:
                hudText.text = "Village";
                break;
            case 5:
                hudText.text = "City";
                break;
            case 6:
                hudText.text = "Hills";
                break;
            case 7:
                hudText.text = "Academy";
                break;
            case 8:
                hudText.text = "Valley";
                break;
            case 9:
                hudText.text = "Plains";
                break;
        }
    }
}
