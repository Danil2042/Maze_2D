using UnityEngine;

public class DataSave : MonoBehaviour
{
    public RestartLevel RL;
    public int Width;
    public int Height;
    public void Awake()
    {
        if (PlayerPrefs.HasKey("Width"))
        {
            Width = PlayerPrefs.GetInt("Width");
        }
        else
        {
            Width = 23;
        }
        if (PlayerPrefs.HasKey("Height"))
        {
            Height = PlayerPrefs.GetInt("Height");
        }
        else
        {
            Height = 15;
        }
    }
    public void NewData()
    {
        Width += 1;
        Height += 1;
        PlayerPrefs.SetInt("Width", Width);
        PlayerPrefs.SetInt("Height", Height);
    }
    public void DelitData()
    {
        PlayerPrefs.DeleteAll();
        RL.ForseRestart();
    }

}
