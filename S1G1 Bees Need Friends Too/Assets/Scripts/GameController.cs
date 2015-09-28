using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

   

    // Information about storing the time
    public float timeS = 59;
    public int timeM = 1;

    // Bool to check if the game is playing
    bool isPlaying;

    // Storing the timerText
    public Text timerText;

    // Storing the score and the score text
    public int score = 0;
    public Text scoreText;

	public int highScore;
	public int highScoreText;

    public bool beesAreClose;

	public bool gameOver;

	public GameObject gameOverScreen;

	public Text GOScoreText;
	public Text GOHSText;

	public bool reload;


    

    void Awake()
    {
        


    }

    // Use this for initialization
    void Start () {
        isPlaying = true;
        beesAreClose = false;

		highScore = PlayerPrefs.GetInt ("HighScore", 0);
	}
	
	// Update is called once per frame
	void Update () {

        timerText.text = timeM.ToString("0") + ":" + timeS.ToString("00");

        scoreText.text = "Score: " + score.ToString();


        if (isPlaying)
        {
            timer();  
        }

		if (gameOver) {

			isPlaying = false;
			endGameOptions();
		}

		if (reload) {

			reset ();
		}
	
	}

	void endGameOptions()
	{


		if (score > highScore) {

			PlayerPrefs.SetInt("HighScore", score);

		}
		GOScoreText.text = "Round Score: " + score.ToString ();
		GOHSText.text = "Current Highscore: " + highScore.ToString ();

		gameOverScreen.SetActive (true);


	}

	void reset()
	{
		Application.LoadLevel ("GameScene");

	}



    void timer()
    {
        timeS -= Time.deltaTime * 1;

        if (timeS <= 0.01f)
        {
            timeS = 59f;
            timeM -= 1;

        }
        if (timeM < 0)
        {
			gameOver = true;
        }

    }
}
