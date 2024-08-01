using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainTaskInteraction : MonoBehaviour
{
    public GameObject RoadSign;
    public Text TakeTheMainTaskText;
    public Text TeleportText;
    public Text MainTask1;
    public Text MainTask2;
    public Text MainTask3;
    public Text MainTask4;
    public Text MainTask5;
    public Text MainTask6;
    public GameObject MainTask1Panel;
    public GameObject MainTask2Panel;
    public GameObject MainTask4Panel;
    public GameObject MainTask5Panel;
    private int currentTask = 0;

    void Start()
    {
        // Oyunun baþýnda, mevcut görevi yükleyin
        if (PlayerPrefs.HasKey("CurrentTask"))
        {
            currentTask = PlayerPrefs.GetInt("CurrentTask");
        }
        LoadTask(currentTask);
    }

    void Update()
    {
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask1.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask1Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask2.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask2Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask4.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask4Panel.SetActive(true);
        }
        if (TeleportText.gameObject.activeSelf && MainTask5.gameObject.activeSelf && Input.GetKeyDown(KeyCode.C))
        {
            TeleportText.gameObject.SetActive(false);
            Teleport();
        }
        if (TeleportText.gameObject.activeSelf && MainTask6.gameObject.activeSelf && Input.GetKeyDown(KeyCode.C))
        {
            TeleportText.gameObject.SetActive(false);
            KingVillageTeleport();
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask5.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask5Panel.SetActive(true);
        }
        if (MainTask1Panel.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            MainTask1Panel.SetActive(false);
            MainTask1.gameObject.SetActive(false);
            MainTask2.gameObject.SetActive(true);
            currentTask = 1;
            SaveProgress();
        }
        if (MainTask2Panel.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            MainTask2Panel.SetActive(false);
            MainTask2.gameObject.SetActive(false);
            MainTask3.gameObject.SetActive(true);
            RoadSign.SetActive(true);
            currentTask = 2;
            SaveProgress();
        }
        if (MainTask3.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("ComplatedTask") >= 3)
            {
                MainTask3.gameObject.SetActive(false);
                MainTask4.gameObject.SetActive(true);
                TakeTheMainTaskText.gameObject.SetActive(false);
                currentTask = 3;
                SaveProgress();
            }
        }
        if (MainTask4Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask4Panel.SetActive(false);
            MainTask4.gameObject.SetActive(false);
            MainTask5.gameObject.SetActive(true);
            currentTask = 4;
            SaveProgress();
        }
        if (MainTask5Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask5Panel.SetActive(false);
            MainTask5.gameObject.SetActive(false);
            MainTask6.gameObject.SetActive(true);
            currentTask = 5;
            SaveProgress();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ResetProgress();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((MainTask1.gameObject.activeSelf || MainTask3.gameObject.activeSelf || MainTask4.gameObject.activeSelf) && other.gameObject.CompareTag("Elf"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if (MainTask2.gameObject.activeSelf && other.gameObject.CompareTag("Mayor"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if (MainTask5.gameObject.activeSelf && other.gameObject.CompareTag("Old"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if (MainTask5.gameObject.activeSelf && other.gameObject.CompareTag("SnowVillage"))
        {
            TeleportText.gameObject.SetActive(true);
        }
        if (MainTask6.gameObject.activeSelf && other.gameObject.CompareTag("KingVillageTeleport"))
        {
            TeleportText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Elf") || other.gameObject.CompareTag("Mayor") || other.gameObject.CompareTag("Old") || other.gameObject.CompareTag("SnowVillage") || other.gameObject.CompareTag("KingVillageTeleport"))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask1Panel.SetActive(false);
            MainTask2Panel.SetActive(false);
            MainTask4Panel.SetActive(false);
            MainTask5Panel.SetActive(false);
            TeleportText.gameObject.SetActive(false);
        }
    }

    void LoadTask(int taskIndex)
    {
        if (taskIndex == 0)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            RoadSign.SetActive(false);
            MainTask1.gameObject.SetActive(true);
            MainTask1Panel.SetActive(false);
            MainTask2.gameObject.SetActive(false);
            MainTask2Panel.SetActive(false);
            MainTask3.gameObject.SetActive(false);
            MainTask4.gameObject.SetActive(false);
            MainTask4Panel.SetActive(false);
            MainTask5.gameObject.SetActive(false);
            MainTask5Panel.SetActive(false);
            MainTask6.gameObject.SetActive(false);

        }
        else if (taskIndex == 1)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask1.gameObject.SetActive(false);
            MainTask1Panel.SetActive(false);
            MainTask2.gameObject.SetActive(true);
        }
        else if (taskIndex == 2)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask2.gameObject.SetActive(false);
            MainTask2Panel.SetActive(false);
            MainTask3.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 3)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask3.gameObject.SetActive(false);
            MainTask4.gameObject.SetActive(true);
        }
        else if (taskIndex == 4)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask4.gameObject.SetActive(false);
            MainTask4Panel.SetActive(false);
            MainTask5.gameObject.SetActive(true);
        }
        else if (taskIndex == 5)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask5.gameObject.SetActive(false);
            MainTask5Panel.SetActive(false);
            MainTask6.gameObject.SetActive(true);
        }
    }

    void SaveProgress()
    {
        PlayerPrefs.SetInt("CurrentTask", currentTask);
        PlayerPrefs.Save();
    }

    // Ýsteðe baðlý olarak, ilerlemeyi sýfýrlamak için bir metod
    public void ResetProgress()
    {
        PlayerPrefs.DeleteKey("CurrentTask");
        currentTask = 0;
        LoadTask(currentTask);
    }
    void Teleport()
    {
        // GameObject'in konumunu (46, 8.6, -82) konumuna taþý
        transform.position = new Vector3(46, 8.6f, -82);
    }
    void KingVillageTeleport()
    {
        transform.position = new Vector3(-337, 16.2f, -57);
    }
}
