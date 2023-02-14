using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Simulation : MonoBehaviour
{
    public TMP_Text timeText, zombieText, humanText, deerText;
    public int dayText = 0, hourText = 0, minuteText = 0;
    private float timer = 5;
    public Graphic icon;
    void Update()
    {
        if (timer >= 5 && timer < 15)
        {
            icon.color = new Color32(255, 150, 35, 200);
        }
        else if (timer >= 15 || timer < 5)
        {
            icon.color = new Color32(0, 0, 0, 200);
            if (timer > 20)
            {
                dayText += 1;
                timer = 0;
            }
        }
        timer += Time.deltaTime;
        hourText = (int)(timer * 1.2);
        minuteText = (int)(timer * 72) % 60;
        timeText.text = "Day " + dayText.ToString() + ":" + hourText.ToString() + ":" + minuteText.ToString();
        zombieText.text = "Zombies: " + GameObject.FindObjectsOfType<Zombie>().Length.ToString();
        humanText.text = "Humans: " + GameObject.FindObjectsOfType<Human>().Length.ToString();
        deerText.text = "Deers: " + GameObject.FindObjectsOfType<Deer>().Length.ToString();
    }
}
