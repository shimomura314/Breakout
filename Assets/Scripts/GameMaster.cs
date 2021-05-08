using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int boxNum;
    public float nowTime;

    // Use this for initialization
    void Start () {
        nowTime = 0;
        boxNum = 100;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Result");
        }        
        nowTime += Time.deltaTime;
        if (boxNum <= 0) {
            GameOver(nowTime.ToString("F0")+"秒でクリア！");
        }
    }
    public void GameOver(string resultMessage) {
        DataSender.resultMessage = resultMessage;
        SceneManager.LoadScene("Result");
    }
}
