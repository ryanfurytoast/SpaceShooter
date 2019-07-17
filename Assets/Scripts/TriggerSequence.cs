using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSequence : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 3f;
    [SerializeField] GameObject deathFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        OnDeathSequence();
    }

    void OnDeathSequence()
    {
        print("dying");
        deathFX.SetActive(true);
        SendMessage("OnPlayerDeath");
        Invoke("ReloadScene", levelLoadDelay);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }

}
