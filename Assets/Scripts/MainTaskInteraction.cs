using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainTaskInteraction : MonoBehaviour
{
    public Canvas KillCanvas;
    public Canvas ForgiveCanvas;
    public Text GoldText;
    public GameObject RoadSign;
    public Text TakeTheMainTaskText;
    public Text TeleportText;
    public Text BribeText;
    public Text GateText;
    public Text KingText;
    public Text MainTask1;
    public Text MainTask2;
    public Text MainTask3;
    public Text MainTask4;
    public Text MainTask5;
    public Text MainTask6;
    public Text MainTask7;
    public Text MainTask8;
    public Text MainTask9;
    public Text MainTask10;
    public Text MainTask11;
    public Text MainTask12;
    public Text MainTask13;
    public Text MainTask14;
    public Text MainTask15;
    public GameObject MainTask1Panel;
    public GameObject MainTask2Panel;
    public GameObject MainTask4Panel;
    public GameObject MainTask5Panel;
    public GameObject MainTask6Panel;
    public GameObject MainTask7Panel;
    public GameObject MainTask8Panel;
    public GameObject MainTask9Panel;
    public GameObject MainTask10Panel;
    public GameObject MainTask12Panel;
    public GameObject MainTask13Panel;
    public GameObject MainTask14Panel;
    private int currentTask = 0;
    public GameObject Gate;
    public GameObject OldGuardionG;
    public GameObject NewGuardion;
    public GameObject KingRoom;

    void Start()
    {
        // Oyunun ba��nda, mevcut g�revi y�kleyin
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
        if (TeleportText.gameObject.activeSelf && (MainTask5.gameObject.activeSelf || MainTask13.gameObject.activeSelf) && Input.GetKeyDown(KeyCode.C))
        {
            TeleportText.gameObject.SetActive(false);
            Teleport();
        }
        if (TeleportText.gameObject.activeSelf && (MainTask6.gameObject.activeSelf || MainTask10.gameObject.activeSelf || MainTask12.gameObject.activeSelf || MainTask14.gameObject.activeSelf) && Input.GetKeyDown(KeyCode.C))
        {
            TeleportText.gameObject.SetActive(false);
            KingVillageTeleport();
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask5.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask5Panel.SetActive(true);
        }
        if (BribeText.gameObject.activeSelf && (MainTask6.gameObject.activeSelf || MainTask10.gameObject.activeSelf) && Input.GetKeyDown(KeyCode.C))
        {
            if (PlayerPrefs.GetInt("Gold") >= 100)
            {
                int bribe = 100;
                int g�ncelalt�n = PlayerPrefs.GetInt("Gold", 0);
                g�ncelalt�n -= bribe;
                PlayerPrefs.SetInt("Gold", g�ncelalt�n);
                UpdateGoldUI(g�ncelalt�n);
                Gate.SetActive(false);
            }  
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask6.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask6Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask7.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask7Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask8.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("Gold") >= 150)
            {
                int bribe = 150;
                int g�ncelalt�n = PlayerPrefs.GetInt("Gold", 0);
                g�ncelalt�n -= bribe;
                PlayerPrefs.SetInt("Gold", g�ncelalt�n);
                UpdateGoldUI(g�ncelalt�n);
                TakeTheMainTaskText.gameObject.SetActive(false);
                MainTask8Panel.SetActive(true);
            }
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask9.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask9Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask10.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask10Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask11.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("Gold") >= 150)
            {
                int bribe = 150;
                int g�ncelalt�n = PlayerPrefs.GetInt("Gold", 0);
                g�ncelalt�n -= bribe;
                PlayerPrefs.SetInt("Gold", g�ncelalt�n);
                UpdateGoldUI(g�ncelalt�n);
                TakeTheMainTaskText.gameObject.SetActive(false);
                MainTask11.gameObject.SetActive(false);
                MainTask12.gameObject.SetActive(true);
                currentTask = 11;
                SaveProgress();
            }
        }
        if (GateText.gameObject.activeSelf && MainTask12.gameObject.activeSelf && Input.GetKey(KeyCode.C))
        {
            GateText.gameObject.SetActive(false);
            OldGuardionG.SetActive(false);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask12.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask12Panel.gameObject.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask13.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask13Panel.SetActive(true);
        }
        if (TakeTheMainTaskText.gameObject.activeSelf && MainTask14.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask14Panel.SetActive(true);
        }
        if (KingText.gameObject.activeSelf && MainTask15.gameObject.activeSelf && Input.GetKey(KeyCode.E))
        {
            MainTask15.gameObject.SetActive(false);
            KingText.gameObject.SetActive(false);
            KillCanvas.gameObject.SetActive(true);
        }
        if (KingText.gameObject.activeSelf && MainTask15.gameObject.activeSelf && Input.GetKey(KeyCode.C))
        {
            MainTask15.gameObject.SetActive(false);
            KingText.gameObject.SetActive(false);
            ForgiveCanvas.gameObject.SetActive(true);
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
            MainVillageTeleport();
            currentTask = 5;
            SaveProgress();
        }
        if (MainTask6Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask6Panel.SetActive(false);
            MainTask6.gameObject.SetActive(false);
            MainTask7.gameObject.SetActive(true);
            MainVillageTeleport();
            currentTask = 6;
            SaveProgress();
        }
        if (MainTask7Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask7Panel.SetActive(false);
            MainTask7.gameObject.SetActive(false);
            MainTask8.gameObject.SetActive(true);
            currentTask = 7;
            SaveProgress();
        }
        if (MainTask8Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask8Panel.SetActive(false);
            MainTask8.gameObject.SetActive(false);
            MainTask9.gameObject.SetActive(true);
            NewGuardion.SetActive(true);
            currentTask = 8;
            SaveProgress();
        }
        if (MainTask9Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask9Panel.SetActive(false);
            MainTask9.gameObject.SetActive(false);
            MainTask10.gameObject.SetActive(true);
            NewGuardion.SetActive(false);
            currentTask = 9;
            SaveProgress();
        }
        if (MainTask10Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask10Panel.SetActive(false);
            MainTask10.gameObject.SetActive(false);
            MainTask11.gameObject.SetActive(true);
            MainVillageTeleport();
            currentTask = 10;
            SaveProgress();
        }
        if (MainTask12Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask12Panel.SetActive(false);
            MainTask12.gameObject.SetActive(false);
            MainTask13.gameObject.SetActive(true);
            currentTask = 12;
            SaveProgress();
        }
        if (MainTask13Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask13Panel.SetActive(false);
            MainTask13.gameObject.SetActive(false);
            MainTask14.gameObject.SetActive(true);
            MainVillageTeleport();
            currentTask = 13;
            SaveProgress();
        }
        if (MainTask14Panel.activeSelf && Input.GetKey(KeyCode.F))
        {
            MainTask14Panel.SetActive(false);
            MainTask14.gameObject.SetActive(false);
            MainTask15.gameObject.SetActive(true);
            KingRoom.SetActive(true);
            KingText.gameObject.SetActive(true);
            KingRoomTeleport();
            currentTask = 14;
            SaveProgress();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ResetProgress();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((MainTask1.gameObject.activeSelf || MainTask3.gameObject.activeSelf || MainTask4.gameObject.activeSelf || MainTask7.gameObject.activeSelf || MainTask8.gameObject.activeSelf) && other.gameObject.CompareTag("Elf"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if ((MainTask2.gameObject.activeSelf ||MainTask11.gameObject.activeSelf) && other.gameObject.CompareTag("Mayor"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if ((MainTask5.gameObject.activeSelf || MainTask13.gameObject.activeSelf) && other.gameObject.CompareTag("Old"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if ((MainTask5.gameObject.activeSelf || MainTask13.gameObject.activeSelf) && other.gameObject.CompareTag("SnowVillage"))
        {
            TeleportText.gameObject.SetActive(true);
        }
        if ((MainTask6.gameObject.activeSelf || MainTask10.gameObject.activeSelf || MainTask12) && other.gameObject.CompareTag("KingVillageTeleport"))
        {
            TeleportText.gameObject.SetActive(true);
        }
        if ((MainTask6.gameObject.activeSelf || MainTask10.gameObject.activeSelf) && other.gameObject.CompareTag("VillageGuardion"))
        {
            BribeText.gameObject.SetActive(true);
        }
        if ((MainTask6.gameObject.activeSelf || MainTask10.gameObject.activeSelf) && other.gameObject.CompareTag("KingVillager"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if (MainTask9.gameObject.activeSelf && other.gameObject.CompareTag("NewGuardion"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if (MainTask12.gameObject.activeSelf && other.gameObject.CompareTag("OldGuardionGate"))
        {
            GateText.gameObject.SetActive(true);
        }
        if (MainTask12.gameObject.activeSelf && other.gameObject.CompareTag("OldGuardion"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
        if (MainTask14.gameObject.activeSelf && other.gameObject.CompareTag("KingGuardion"))
        {
            TakeTheMainTaskText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Elf") || other.gameObject.CompareTag("Mayor") || other.gameObject.CompareTag("Old") || other.gameObject.CompareTag("SnowVillage") || other.gameObject.CompareTag("KingVillageTeleport") || other.gameObject.CompareTag("VillageGuardion") || other.gameObject.CompareTag("KingVillager") || other.gameObject.CompareTag("NewGuardion") || other.gameObject.CompareTag("OldGuardion") || other.gameObject.CompareTag("KingGuardion"))
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            TeleportText.gameObject.SetActive(false);
            BribeText.gameObject.SetActive(false);
            GateText.gameObject.SetActive(false);
            MainTask1Panel.SetActive(false);
            MainTask2Panel.SetActive(false);
            MainTask4Panel.SetActive(false);
            MainTask5Panel.SetActive(false);
            MainTask6Panel.SetActive(false);
            MainTask7Panel.SetActive(false);
            MainTask8Panel.SetActive(false);
            MainTask9Panel.SetActive(false);
            MainTask10Panel.SetActive(false);
            MainTask12Panel.SetActive(false);
            MainTask13Panel.SetActive(false);
            MainTask14Panel.SetActive(false);
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
            MainTask6Panel.SetActive(false);
            MainTask7.gameObject.SetActive(false);
            MainTask7Panel.SetActive(false);
            MainTask8.gameObject.SetActive(false);
            MainTask8Panel.SetActive(false);
            MainTask9.gameObject.SetActive(false);
            MainTask9Panel.SetActive(false);
            MainTask10.gameObject.SetActive(false);
            MainTask10Panel.SetActive(false);
            MainTask11.gameObject.SetActive(false);
            MainTask12.gameObject.SetActive(false);
            MainTask12Panel.SetActive(false);
            MainTask13.gameObject.SetActive(false);
            MainTask13Panel.SetActive(false);
            MainTask14.gameObject.SetActive(false);
            MainTask14Panel.SetActive(false);
            MainTask15.gameObject.SetActive(false);
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
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 4)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask4.gameObject.SetActive(false);
            MainTask4Panel.SetActive(false);
            MainTask5.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 5)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask5.gameObject.SetActive(false);
            MainTask5Panel.SetActive(false);
            MainTask6.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 6)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask6.gameObject.SetActive(false);
            MainTask6Panel.SetActive(false);
            MainTask7.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 7)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask7.gameObject.SetActive(false);
            MainTask7Panel.SetActive(false);
            MainTask8.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 8)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask8.gameObject.SetActive(false);
            MainTask8Panel.SetActive(false);
            MainTask9.gameObject.SetActive(true);
            NewGuardion.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 9)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask9.gameObject.SetActive(false);
            MainTask9Panel.SetActive(false);
            MainTask10.gameObject.SetActive(true);
            NewGuardion.SetActive(false);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 10)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask10.gameObject.SetActive(false);
            MainTask10Panel.SetActive(false);
            MainTask11.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 11)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask11.gameObject.SetActive(false);
            MainTask12.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 12)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask12.gameObject.SetActive(false);
            MainTask12Panel.SetActive(false);
            MainTask13.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 13)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask13.gameObject.SetActive(false);
            MainTask13Panel.SetActive(false);
            MainTask14.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
        else if (taskIndex == 14)
        {
            TakeTheMainTaskText.gameObject.SetActive(false);
            MainTask14.gameObject.SetActive(false);
            MainTask14Panel.SetActive(false);
            MainTask15.gameObject.SetActive(true);
            RoadSign.SetActive(true);
        }
    }

    void SaveProgress()
    {
        PlayerPrefs.SetInt("CurrentTask", currentTask);
        PlayerPrefs.Save();
    }

    // �ste�e ba�l� olarak, ilerlemeyi s�f�rlamak i�in bir metod
    public void ResetProgress()
    {
        PlayerPrefs.DeleteKey("CurrentTask");
        currentTask = 0;
        LoadTask(currentTask);
    }
    void Teleport()
    {
        transform.position = new Vector3(46, 8.6f, -82);
    }
    void KingVillageTeleport()
    {
        transform.position = new Vector3(-337, 17.4f, -57);
    }
    void KingRoomTeleport()
    {
        transform.position = new Vector3(-346, 24.4f, -80);
    }
    void MainVillageTeleport()
    {
        transform.position = new Vector3(-1.4f, 1, -14);
    }
    void UpdateGoldUI(int goldAmount)
    {
        GoldText.text = goldAmount.ToString();
    }
}
