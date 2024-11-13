using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    DataSave DS;
    void Start()
    {
        DS = FindObjectOfType<DataSave>(); // ������� ����� DataSave � �����
        if (DS == null)
        {
            Debug.LogError("DataSave �� ������! ���������, ��� ������ DataSave ���� � �����.");
        }
        else
        {
            Debug.Log("DataSave ������� ������ � ���������������.");
        }
    }

    public void Restart()
    {
        if (DS == null)
        {
            return;
        }

        DS.NewData();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ForseRestart()
    {
        if (DS == null)
        {
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
