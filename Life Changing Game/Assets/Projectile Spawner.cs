using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public ProjectileController PC;
    void Start()
    {
        StartCoroutine(Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Coroutine()
    {
        RandomizeTime();
        WaitForSeconds waitTime = new WaitForSeconds(timer);
        yield return waitTime;
        PC.ShootRight();

    }
    void RandomizeTime()
    {
        timer = (float)(Random.Range(0,6) * 0.2 + 0.1);
    }
}
