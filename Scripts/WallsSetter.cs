using UnityEngine;

public class WallsSetter : MonoBehaviour
{
    public GameObject RightExitWall;
    public GameObject TopExitWall;
    DataSave data;

    void Start()
    {
        data = FindObjectOfType<DataSave>();
        if (data == null)
        {
            return;
        }

        RightExitWall.transform.position = new Vector2(data.Width, 0);
        TopExitWall.transform.position = new Vector2(0, data.Height);
    }
}
