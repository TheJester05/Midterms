using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public GameObject henPrefab;
    public GameObject roosterPrefab;

    private void Start()
    {
        StartCoroutine(Mature());
    }

    IEnumerator Mature()
    {
        yield return new WaitForSeconds(10f);
        GameObject matureBird = Random.value < 0.5f ? henPrefab : roosterPrefab;
        Instantiate(matureBird, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
