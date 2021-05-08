using UnityEngine;

public class TimeMaster : MonoBehaviour
{
    // not used
    private int minutes;
    private float seconds;
    
    public float Seconds{
        get{ return this.seconds; }
        private set{ this.seconds = value; }
    }
    
    public int Minutes{
        get{ return this.minutes; }
        private set{ this.minutes = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        minutes = 0;
        seconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if(seconds >= 60f){
            minutes++;
            seconds -= 60;
        }
    }
}
