using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    DataSave DS;
    void Start()
    {
        DS = FindObjectOfType<DataSave>(); // Попытка найти DataSave в сцене
        if (DS == null)
        {
            Debug.LogError("DataSave не найден! Убедитесь, что объект DataSave есть в сцене.");
        }
        else
        {
            Debug.Log("DataSave успешно найден и инициализирован.");
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
