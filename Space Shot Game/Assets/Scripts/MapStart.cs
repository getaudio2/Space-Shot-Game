using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStart : MonoBehaviour
{
    private ParticleSystem stars;
    private ParticleSystem stars1;
    public float initTime = 100;
    // Start is called before the first frame update
    void Start()
    {
        stars = GameObject.Find("Stars").GetComponent<ParticleSystem>();
        stars.Simulate(100);
        stars.Play();

        stars1 = GameObject.Find("Stars1").GetComponent<ParticleSystem>();
        stars1.Simulate(100);
        stars1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
