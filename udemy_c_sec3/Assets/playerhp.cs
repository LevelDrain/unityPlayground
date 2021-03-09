using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhp : MonoBehaviour
{
    private float hp;
    public Slider hpslider;
    //[SerializeField]
    //private int minute;
    //[SerializeField]
    //private float seconds;
    //private float oldSeconds;

    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        hpslider.value = 0;
        //minute = 0;
        //seconds = 0;
        //oldSeconds = 0f;
    }

    void Update()
    {
        hp -= Time.deltaTime;
        Text HPText = GetComponent<Text>();
        HPText.color = new Color(50f / 255f, 0f / 255f, 10f / 255f, 1f);
        HPText.text = "うえしま HP:" + hp.ToString("00");

        hpslider.value = hp;

        //seconds -= Time.deltaTime;
        //if (seconds >= 60f)
        //{
        //    minute++;
        //    seconds = seconds - 60;
        //}

        //if ((int)seconds != (int)oldSeconds)
        //{
        //    Debug.Log(seconds);
        //}
    }
}
