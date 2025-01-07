using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void MarkerBasedMenuScene()
    {
        SceneManager.LoadScene("MarkerBasedMenu");
    }

    public void AnatomyScene()
    {
        SceneManager.LoadScene("HumanAnatomy");
    }

    public void BrainScene()
    {
        SceneManager.LoadScene("HumanBrain");
    }

    public void HeartScene()
    {
        SceneManager.LoadScene("HumanHeart");
    }

    public void KidneyScene()
    {
        SceneManager.LoadScene("HumanKidney");
    }

    public void EarScene()
    {
        SceneManager.LoadScene("HumanEar");
    }

    public void DigestiveScene()
    {
        SceneManager.LoadScene("HumanDigestive");
    }

    public void EyeScene()
    {
        SceneManager.LoadScene("HumanEye");
    }

    public void CirculatoryScene()
    {
        SceneManager.LoadScene("HumanCirculatory");
    }

    public void FetusScene()
    {
        SceneManager.LoadScene("HumanFetus");
    }

    public void MuscleScene()
    {
        SceneManager.LoadScene("HumanMuscle");
    }

    public void PlainScene()
    {
        SceneManager.LoadScene("plain");
    }

    public void EntryScene()
    {
        SceneManager.LoadScene("EntryMenu");

    }

    public void MarkerlessMenu()
    {
        SceneManager.LoadScene("MarkerLessMenu");

    }

    public void lessEvlofHuman()
    {
        SceneManager.LoadScene("EvlOfHominins");

    }

    public void lessHumanAna()
    {
        SceneManager.LoadScene("HumanAna");

    }

    public void lessHumanCircu()
    {
        SceneManager.LoadScene("HumanCircu");

    }

    public void lessHumanDig()
    {
        SceneManager.LoadScene("HumanDig");

    }

    public void lessHumanMus()
    {
        SceneManager.LoadScene("HumanMus");

    }

    public void lessHumanSkele()
    {
        SceneManager.LoadScene("HumanSkele");

    }

    public void lessLeafAna()
    {
        SceneManager.LoadScene("LeafAnatomy");

    }

    public void lessMedEquip()
    {
        SceneManager.LoadScene("MedEquip");

    }

    public void LessSkinAna()
    {
        SceneManager.LoadScene("SkinAnatomy");

    }

    public void LessTooth()
    {
        SceneManager.LoadScene("Tooth");

    }

    public void Quiz()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void VideoScene()
    {
        SceneManager.LoadScene("Video");
    }

    public void surveyScene()
    {
        SceneManager.LoadScene("survey");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Exited the App");
    }
}