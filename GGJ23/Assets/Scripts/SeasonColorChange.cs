using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SeasonColorChange : MonoBehaviour
{
    [SerializeField]
    float[] changeSeasonTimes;

    [SerializeField]
    Color[] seasonColors;

    int currSeasonIndex = 0;

    Timer timer;

    bool endReached = false;

    private void Awake()
    {
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!endReached && timer.GetElapsedTime() >= changeSeasonTimes[currSeasonIndex])
        {
            ChangeSeason();
        }
    }

    void ChangeSeason()
    {
        if (currSeasonIndex < seasonColors.Length)
        {
            GetComponent<Image>().color = seasonColors[currSeasonIndex];
        }
        if (currSeasonIndex >= seasonColors.Length - 1)
        {
            endReached = true;
        }
        ++currSeasonIndex;
    }
}
