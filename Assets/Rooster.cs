using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Perish());
    }

    IEnumerator Perish()
    {
        yield return new WaitForSeconds(40f);
        Destroy(gameObject);
    }
}
