using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    public GameObject sensor;
    
    public GameObject act1Player;
    public GameObject act2Player;

    private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        act1Player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (act1Player.transform)
        {
            act1Player.SetActive(false);
            act2Player.SetActive(true);
        }
    }
}
