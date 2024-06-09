using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject chickPrefab;
    

    private void Start()
    {
        StartCoroutine(Hatch());
    }

    IEnumerator Hatch()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(chickPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
