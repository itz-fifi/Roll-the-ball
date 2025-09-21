using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    // Update is called once per frame
    void Update()
    {

        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime; 
        }

        else if(remainingTime <= 0)
        {
            timerText.text = "00:00";
            timerText.color = Color.red;
            return;
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60f);
        int seconds = Mathf.FloorToInt(remainingTime % 60f);    
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
