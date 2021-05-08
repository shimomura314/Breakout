using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int minutes;
    private float seconds;
    private float oldSeconds;
    private Text timerText;

    private TimeMaster timeMaster;

        
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponentInChildren<Text>();

        timeMaster = GameObject.Find("Master").GetComponent<TimeMaster>();
        minutes = timeMaster.Minutes;
        seconds = timeMaster.Seconds;
        oldSeconds = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        seconds = timeMaster.Seconds;
        if( (int)seconds != (int)oldSeconds ){
            timerText.text = minutes.ToString("00")+":"+((int)seconds).ToString("00");
        }
        oldSeconds = seconds;     
    }
}
