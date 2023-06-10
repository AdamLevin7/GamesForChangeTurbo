using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    public float randomY;

    private void Start()
    {
        randomY = (float)(Random.Range(0, 12) * 0.5 - 2.25);
    }
    public void ShootRight()
    {
        for (int y = -12; y < 13; y += 2)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 0);
            Instantiate(projectile, new Vector3(-12, randomY, 0), rot);
        }
    }
    
}
