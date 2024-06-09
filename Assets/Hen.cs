using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public GameObject eggPrefab;

    private void Start()
    {
        StartCoroutine(LayEggs());
        StartCoroutine(Perish());
    }

    IEnumerator LayEggs()
    {
        yield return new WaitForSeconds(30f);
        int eggCount = Random.Range(2, 11);
        for (int i = 0; i < eggCount; i++)
        {
            Instantiate(eggPrefab, transform.position, Quaternion.identity);
        }
    }

    IEnumerator Perish()
    {
        yield return new WaitForSeconds(40f);
        Destroy(gameObject);
    }
}
