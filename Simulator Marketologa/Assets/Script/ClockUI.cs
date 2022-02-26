using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockUI : MonoBehaviour
{
    private const float REAL_SECONDS_PER_INGAME_DAY = 60f;

    public Transform clockHoureHandTransform;
    public Transform clockMinuteHandTransform;
    public TextMeshProUGUI timeText;
    private float day;


    private void Awake()
    {
        clockHoureHandTransform = transform.Find("HourseArrow");
        clockMinuteHandTransform = transform.Find("MinuteArrow");
        timeText = transform.Find("Time").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;
        float dayNormalized = day % 1f;

        float rotationDegreesDay = 360f;
        clockHoureHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesDay);

        float hoursePerDay = 24;
        clockMinuteHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesDay * hoursePerDay);

        string hoursString = Mathf.Floor(dayNormalized * hoursePerDay).ToString("00");

        float minutesPerHour = 60f;
        string minuteString = Mathf.Floor(((dayNormalized * hoursePerDay)%1f) * minutesPerHour).ToString("00");

        timeText.text = hoursString + ":" + minuteString;

    }
}
