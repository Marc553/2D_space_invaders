using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shooter : MonoBehaviour
{
    public GameObject bullet;
    public bool coldDown;

    private void Update()
    {
        if(coldDown == false)
        {
            StartCoroutine(Shoother());
        }
        
    }

    private IEnumerator Shoother()
    {
        coldDown = true;
        int index = Random.Range(0, 50);
        Instantiate(bullet, transform.position, transform.rotation);
        yield return new WaitForSeconds(index);
        coldDown = false;
    }
}

