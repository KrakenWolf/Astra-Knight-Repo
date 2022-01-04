using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameManager gameManager;
    public Button startButton;
    public GameObject Trigger;

    public GameObject mainPlayer1;
    public GameObject mainPlayer2;
    public GameObject bossPlayer;
    public GameObject cutscenePlayer;

    private void Awake()
    {
        Button button = startButton.GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Object.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (gameObject == mainPlayer1)
        {
            SceneManager.LoadScene(2);
        }
        if (mainPlayer2)
        {
            SceneManager.LoadScene(3);
        }
        if (bossPlayer)
        {
            SceneManager.LoadScene(4);
        }
        if (cutscenePlayer)
        {
            SceneManager.LoadScene(5);
        }
    }
}
