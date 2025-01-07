using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class forms : MonoBehaviour
{
    // Reference to the TMP_InputField where the user will enter their feedback
    [SerializeField] TMP_InputField feedbackSent;

    // The URL for the Google Form that we're going to send data to
    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdalxtzvCobFsfb1clJABF-CSFHAKCjWKcBiM1rZJazO5jpNA/formResponse";

    // This method is called when the user wants to send their feedback
    public void Send()
    {
        StartCoroutine(Post(feedbackSent.text));
    }

    // Coroutine to handle the process of sending the feedback to the Google Form
    IEnumerator Post(string s)
    {
        WWWForm form = new WWWForm();
        // Add the feedback text to the form, mapped to the specific entry field in the Google Form
        form.AddField("entry.1678875753", s);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        // Wait until the web request is finished before continuing
        yield return www.SendWebRequest();
    }
}