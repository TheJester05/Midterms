using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TagBasedCounter : MonoBehaviour
{
    public TextMeshProUGUI eggCountText;
    public TextMeshProUGUI chickCountText;
    public TextMeshProUGUI henCountText;
    public TextMeshProUGUI roosterCountText;

    void Start()
    {
        UpdateCounterUI();
    }
    void Update()
    {
        UpdateCounterUI();
    }
    void UpdateCounterUI()
    {
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");
        GameObject[] chicks = GameObject.FindGameObjectsWithTag("Chick");
        GameObject[] hens = GameObject.FindGameObjectsWithTag("Hen");
        GameObject[] roosters = GameObject.FindGameObjectsWithTag("Rooster");

        eggCountText.text = "Eggs: " + eggs.Length;
        chickCountText.text = "Chicks: " + chicks.Length;
        henCountText.text = "Hens: " + hens.Length;
        roosterCountText.text = "Roosters: " + roosters.Length;
    }
}
