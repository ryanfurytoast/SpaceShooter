using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;

    // Start is called before the first frame update
    void Start()
    {
        deathFX.SetActive(false);
    }

    void OnParticelCollision(GameObject other)
    {
        Destroy(gameObject);
        Instantiate(deathFX, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
