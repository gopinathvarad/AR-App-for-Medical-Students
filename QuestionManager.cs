using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Text questionText;
    public Text scoreTxt;
    public Text FinalScr;

    public Button[] replyButtons;

    public QuestionData qtsData;

    public GameObject Correct;
    public GameObject Wrong;
    public GameObject GameFinish;

    private int currentQuestion = 0;
    private static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; // Reset score
        scoreTxt.text = "0"; // Reset the displayed score
        SetQts(currentQuestion);
        Correct.SetActive(false);
        Wrong.SetActive(false);
        GameFinish.SetActive(false);
    }

    void SetQts(int questionIndex)
    {
        questionText.text = qtsData.questions[questionIndex].questionText;

        // Ensure that the number of buttons matches the number of replies length
        if (replyButtons.Length != qtsData.questions[questionIndex].replies.Length)
        {
            Debug.LogWarning("Mismatch between number of reply buttons and replies.");
            return;
        }

        foreach (Button r in replyButtons)
        {
            r.onClick.RemoveAllListeners();
        }

        for (int i = 0; i < replyButtons.Length; i++)
        {
            replyButtons[i].GetComponentInChildren<Text>().text = qtsData.questions[questionIndex].replies[i];
            int replyIndex = i;
            replyButtons[i].onClick.AddListener(() => {
                CheckRep(replyIndex);
            });
        }
    }

    // This function makes sure that whether the answer has been been written right or wrong

    void CheckRep(int replyIndex)
    {
        if (replyIndex == qtsData.questions[currentQuestion].correctReplyIndex)
        {
            score++;
            scoreTxt.text = score.ToString();

            Correct.SetActive(true);

            foreach (Button r in replyButtons)
            {
                r.interactable = false;
            }

            StartCoroutine(NextQuestion());
        }
        else
        {
            Wrong.SetActive(true);

            foreach (Button r in replyButtons)
            {
                r.interactable = false;
            }

            StartCoroutine(NextQuestion());
        }
    }

    // sets the next question and also make sure to mark the final marking based on the score!

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(2);

        currentQuestion++;
        if (currentQuestion < qtsData.questions.Length)
        {
            Reset();
        }
        else
        {
            GameFinish.SetActive(true);

            float scorePercent = (float)score / qtsData.questions.Length * 100;

            FinalScr.text = "You scored " + scorePercent.ToString("F0") + "%\n";

            if (scorePercent < 50)
            {
                FinalScr.text += "Game Finished";
            }
            else if (scorePercent < 60)
            {
                FinalScr.text += "Keep pushing!";
            }
            else if (scorePercent < 70)
            {
                FinalScr.text += "Good Job!";
            }
            else if (scorePercent < 80)
            {
                FinalScr.text += "Well Done!";
            }
            else
            {
                FinalScr.text += "You are Amazing!!";
            }
        }
    }

    public void Reset()
    {
        Correct.SetActive(false);
        Wrong.SetActive(false);

        foreach (Button r in replyButtons)
        {
            r.interactable = true;
        }
        SetQts(currentQuestion);
    }
}