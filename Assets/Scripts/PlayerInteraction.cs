using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Text GoldText;
    public Text ComplatedTask;
    public GameObject RoadSign;
    public bool freetasktemas = false;
    public bool tasktemas = false;
    public GameObject TaskText;
    public List<GameObject> TaskList;
    public GameObject FreeTaskApple;
    public GameObject FreeTask;
    public GameObject Task1;
    public GameObject Task2;
    public GameObject Task3;
    public GameObject Task4;
    public GameObject Task5;
    public GameObject Task6;
    public bool freetaskg1, freetaskg2, freetaskg3, freetaskg1temas, freetaskg2temas, freetaskg3temas = false;
    public bool task1g1, task1g2, task1g3, task1g1temas, task1g2temas, task1g3temas = false;
    public bool task2g1, task2g2, task2g3, task2g4, task2g1temas, task2g2temas, task2g3temas, task2g4temas = false;
    public bool task3g1, task3g2, task3g3, task3g1temas, task3g2temas, task3g3temas = false;
    public bool task4g1, task4g2, task4g3, task4g4, task4g1temas, task4g2temas, task4g3temas, task4g4temas = false;
    public bool task5g1, task5g2, task5g3, task5g1temas, task5g2temas, task5g3temas = false;
    public bool task6g1, task6g2, task6g3, task6g4, task6g1temas, task6g2temas, task6g3temas, task6g4temas = false;
    public Text BottleFeedBack;
    public Text OrangeFeedBack;
    public Text GreenFeedBack;
    public Text RedFeedBack;
    public Text CheeseFeedBack;



    void Start()
    {
        GoldText.text = PlayerPrefs.GetInt("Gold").ToString();
        ComplatedTask.text = PlayerPrefs.GetInt("ComplatedTask").ToString();
        TaskText.SetActive(false);
        tasktemas = false;
        TaskList.Add(Task1);
        TaskList.Add(Task2);
        TaskList.Add(Task3);
        TaskList.Add(Task4);
        TaskList.Add(Task5);
        TaskList.Add(Task6);
        TaskList.Add(FreeTask);
        foreach (GameObject task in TaskList)
        {
            task.SetActive(false);
        }
    }


    void Update()
    {
        // Görev alma
        if ((tasktemas == true) && Input.GetKeyDown(KeyCode.E))
        {
            RoadSign.SetActive(false);
            FreeTaskApple.SetActive(false);
            TaskText.SetActive(false);
            tasktemas = false;
            GameObject randomTask = GetRandomTask();
            randomTask.SetActive(true);
        }
        if ((freetasktemas == true) && Input.GetKeyDown(KeyCode.E))
        {
            RoadSign.SetActive(false);
            FreeTaskApple.SetActive(false);
            TaskText.SetActive(false);
            freetasktemas = false;
            FreeTask.SetActive(true);
        }

        // Görev 1. aþama
        if ((task1g1temas || task2g1temas || task3g1temas || task4g1temas || task5g1temas || task6g1temas || freetaskg1temas == true) && Input.GetKeyDown(KeyCode.E))
        {
            if (freetaskg1temas == true)
            {
                freetaskg1 = true;
                freetaskg1temas = false;
                Debug.Log("Portakal toplandý.");
                OrangeFeedBack.gameObject.SetActive(true);
            }
            else
            {
                BottleBuy();
                BottleFeedBack.gameObject.SetActive(true);
            }

        }

        // Görev 2. aþama
        if ((task1g2temas || task2g2temas || task3g2temas || task4g2temas || task5g2temas || task6g2temas || freetaskg2temas == true) && Input.GetKeyDown(KeyCode.E))
        {
            if (task1g2temas == true)
            {
                task1g2 = true;
                task1g2temas = false;
                Debug.Log("Portakal toplandý.");
                OrangeFeedBack.gameObject.SetActive(true);
            }
            if (task2g2temas == true)
            {
                task2g2 = true;
                task2g2temas = false;
                Debug.Log("Portakal toplandý.");
                OrangeFeedBack.gameObject.SetActive(true);
            }
            if (task3g2temas == true)
            {
                task3g2 = true;
                task3g2temas = false;
                Debug.Log("Portakal toplandý.");
                OrangeFeedBack.gameObject.SetActive(true);
            }
            if (task4g2temas == true)
            {
                task4g2 = true;
                task4g2temas = false;
                Debug.Log("Portakal toplandý.");
                OrangeFeedBack.gameObject.SetActive(true);
            }
            if (task5g2temas == true)
            {
                task5g2 = true;
                task5g2temas = false;
                Debug.Log("yeþil elma toplandý.");
                GreenFeedBack.gameObject.SetActive(true);
            }
            if (task6g2temas == true)
            {
                task6g2 = true;
                task6g2temas = false;
                Debug.Log("yeþil elma toplandý.");
                GreenFeedBack.gameObject.SetActive(true);
            }
            if (freetaskg2temas == true)
            {
                freetaskg2 = true;
                freetaskg2temas = false;
                Debug.Log("yeþil elma toplandý.");
                GreenFeedBack.gameObject.SetActive(true);
            }

        }

        // Görev 3. aþama
        if ((task1g3temas || task2g3temas || task3g3temas || task4g3temas || task5g3temas || task6g3temas || freetaskg3temas == true) && Input.GetKeyDown(KeyCode.E))
        {
            if (task1g3temas == true)
            {
                task1g3 = true;
                task1g3temas = false;
                Debug.Log("Yeþil elma toplandý.");
                GreenFeedBack.gameObject.SetActive(true);
            }
            if (task2g3temas == true)
            {
                task2g3 = true;
                task2g3temas = false;
                Debug.Log("Yeþil elma toplandý.");
                GreenFeedBack.gameObject.SetActive(true);
            }
            if (task3g3temas == true)
            {
                task3g3 = true;
                task3g3temas = false;
                Debug.Log("Kýrmýzý elma toplandý.");
                RedFeedBack.gameObject.SetActive(true);
            }
            if (task4g3temas == true)
            {
                task4g3 = true;
                task4g3temas = false;
                Debug.Log("Kýrmýzý elma toplandý.");
                RedFeedBack.gameObject.SetActive(true);
            }
            if (task5g3temas == true)
            {
                task5g3 = true;
                task5g3temas = false;
                Debug.Log("Kýrmýzý elma toplandý.");
                RedFeedBack.gameObject.SetActive(true);
            }
            if (task6g3temas == true)
            {
                task6g3 = true;
                task6g3temas = false;
                Debug.Log("Kýrmýzý elma toplandý.");
                RedFeedBack.gameObject.SetActive(true);
            }
            if (freetaskg3temas == true)
            {
                freetaskg3 = true;
                freetaskg3temas = false;
                Debug.Log("Kýrmýzý elma toplandý.");
                RedFeedBack.gameObject.SetActive(true);
            }
        }

        // Görev 4. aþama
        if ((task2g4temas || task4g4temas || task6g4temas == true) && Input.GetKeyDown(KeyCode.E))
        {
            CheeseBuy();
            CheeseFeedBack.gameObject.SetActive(true);
        }

        // görev 1 bitiþ
        if (task1g1 && task1g2 && task1g3 == true)
        {
            RoadSign.SetActive(true);
            Task1.SetActive(false);
            task1g1 = false;
            task1g2 = false;
            task1g3 = false;
            Debug.Log("görev 1 baþarýlý.");
            int ödül = 50;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }
        // görev 2 bitiþ
        if (task2g1 && task2g2 && task2g3 && task2g4 == true)
        {
            RoadSign.SetActive(true);
            Task2.SetActive(false);
            task2g1 = false;
            task2g2 = false;
            task2g3 = false;
            task2g4 = false;
            Debug.Log("görev 2 baþarýlý.");
            int ödül = 120;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }
        // Görev 3 bitiþ
        if (task3g1 && task3g2 && task3g3 == true)
        {
            RoadSign.SetActive(true);
            Task3.SetActive(false);
            task3g1 = false;
            task3g2 = false;
            task3g3 = false;
            Debug.Log("görev 3 baþarýlý.");
            int ödül = 50;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }
        // Görev 4 bitiþ
        if (task4g1 && task4g2 && task4g3 && task4g4 == true)
        {
            RoadSign.SetActive(true);
            Task4.SetActive(false);
            task4g1 = false;
            task4g2 = false;
            task4g3 = false;
            task4g4 = false;
            Debug.Log("görev 4 baþarýlý.");
            int ödül = 100;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }
        // Görev 5 bitiþ
        if (task5g1 && task5g2 && task5g3 == true)
        {
            RoadSign.SetActive(true);
            Task5.SetActive(false);
            task5g1 = false;
            task5g2 = false;
            task5g3 = false;
            Debug.Log("görev 5 baþarýlý.");
            int ödül = 75;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }
        // Görev 6 bitiþ
        if (task6g1 && task6g2 && task6g3 && task6g4 == true)
        {
            RoadSign.SetActive(true);
            Task6.SetActive(false);
            task6g1 = false;
            task6g2 = false;
            task6g3 = false;
            task6g4 = false;
            Debug.Log("görev 6 baþarýlý.");
            int ödül = 140;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }
        // Free görev bitiþ
        if (freetaskg1 && freetaskg2 && freetaskg3 == true)
        {
            RoadSign.SetActive(true);
            FreeTaskApple.SetActive(true);
            FreeTask.SetActive(false);
            freetaskg1 = false;
            freetaskg2 = false;
            freetaskg3 = false;
            Debug.Log("free task baþarýlý.");
            int ödül = 20;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            güncelaltýn += ödül;
            PlayerPrefs.SetInt("Gold", güncelaltýn);
            UpdateGoldUI(güncelaltýn);
            int ComplatedTask = PlayerPrefs.GetInt("ComplatedTask", 0);
            ComplatedTask += 1;
            PlayerPrefs.SetInt("ComplatedTask", ComplatedTask);
            UpdateComplatedUI(ComplatedTask);
            PlayerPrefs.Save();
        }

        // Görevi iptal etme
        if (Input.GetKeyDown(KeyCode.R))
        {
            BoolToFalse();
            RoadSign.SetActive(true);
            FreeTaskApple.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RoadSign"))
        {
            TaskText.SetActive(true);
            tasktemas = true;
        }
        if (other.gameObject.CompareTag("FreeTaskApple"))
        {
            TaskText.SetActive(true);
            freetasktemas = true;
        }
        if (other.gameObject.CompareTag("Bottle"))
        {
            Debug.Log("Bottle");
            if (Task1.activeSelf == true)
            {
                task1g1temas = true;
            }
            if (Task2.activeSelf == true)
            {
                task2g1temas = true;
            }
            if (Task3.activeSelf == true)
            {
                task3g1temas = true;
            }
            if (Task4.activeSelf == true)
            {
                task4g1temas = true;
            }
            if (Task5.activeSelf == true)
            {
                task5g1temas = true;
            }
            if (Task6.activeSelf == true)
            {
                task6g1temas = true;
            }
        }
        if (other.gameObject.CompareTag("OrangeTree") && (Task1.activeSelf || Task2.activeSelf || Task3.activeSelf || Task4.activeSelf || FreeTask.activeSelf == true))
        {
            Debug.Log("Orange");
            if (Task1.activeSelf == true)
            {
                task1g2temas = true;
                Debug.Log("görev 1 temas saðlandý.");
            }
            if (Task2.activeSelf == true)
            {
                task2g2temas = true;
                Debug.Log("Görev 2 temas saðlandý.");
            }
            if (Task3.activeSelf == true)
            {
                task3g2temas = true;
                Debug.Log("Görev 3 temas saðlandý.");
            }
            if (Task4.activeSelf == true)
            {
                task4g2temas = true;
                Debug.Log("Görev 4 temas saðlandý.");
            }
            if (FreeTask.activeSelf == true)
            {
                freetaskg1temas = true;
                Debug.Log("Free task temas saðlandý.");
            }
        }
        if (other.gameObject.CompareTag("GreenAppleTree") && (Task1.activeSelf || Task2.activeSelf || Task5.activeSelf || Task6.activeSelf || FreeTask.activeSelf == true))
        {
            Debug.Log("GreenApple");
            if (Task1.activeSelf == true)
            {
                task1g3temas = true;
                Debug.Log("görev 1 temas saðlandý.");
            }
            if (Task2.activeSelf == true)
            {
                task2g3temas = true;
                Debug.Log("Görev 2 temas saðlandý.");
            }
            if (Task5.activeSelf == true)
            {
                task5g2temas = true;
                Debug.Log("Görev 5 temas saðlandý.");
            }
            if (Task6.activeSelf == true)
            {
                task6g2temas = true;
                Debug.Log("Görev 6 temas saðlandý.");
            }
            if (FreeTask.activeSelf == true)
            {
                freetaskg2temas = true;
                Debug.Log("Free task temas saðlandý.");
            }
        }
        if (other.gameObject.CompareTag("RedAppleTree") && (Task3.activeSelf || Task4.activeSelf || Task5.activeSelf || Task6.activeSelf || FreeTask.activeSelf == true))
        {
            Debug.Log("RedApple");
            if (Task3.activeSelf == true)
            {
                task3g3temas = true;
                Debug.Log("görev 3 temas saðlandý.");
            }
            if (Task4.activeSelf == true)
            {
                task4g3temas = true;
                Debug.Log("görev 4 temas saðlandý.");
            }
            if (Task5.activeSelf == true)
            {
                task5g3temas = true;
                Debug.Log("görev 5 temas saðlandý.");
            }
            if (Task6.activeSelf == true)
            {
                task6g3temas = true;
                Debug.Log("görev 6 temas saðlandý.");
            }
            if (FreeTask.activeSelf == true)
            {
                freetaskg3temas = true;
                Debug.Log("Free task temas saðlandý.");
            }
        }
        if (other.gameObject.CompareTag("Cheese") && (Task2.activeSelf || Task4.activeSelf || Task6.activeSelf == true))
        {
            Debug.Log("Cheese");
            if (Task2.activeSelf == true)
            {
                task2g4temas = true;
                Debug.Log("Görev 2 temas saðlandý.");
            }
            if (Task4.activeSelf == true)
            {
                task4g4temas = true;
                Debug.Log("Görev 4 temas saðlandý.");
            }
            if (Task6.activeSelf == true)
            {
                task6g4temas = true;
                Debug.Log("Görev 6 temas saðlandý.");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RoadSign") || other.CompareTag("Bottle") || other.CompareTag("GreenAppleTree") || other.CompareTag("OrangeTree") || other.CompareTag("RedAppleTree") || other.CompareTag("Cheese") || other.CompareTag("FreeTaskApple"))
        {
            TemasToFalse();
        }
    }

    public GameObject GetRandomTask()
    {
        int randomIndex = Random.Range(0, TaskList.Count);
        return TaskList[randomIndex];
    }
    void BoolToFalse()
    {
        task1g1 = task1g2 = task1g3 = task2g1 = task2g2 = task2g3 = task2g4 = task3g1 = task3g2 = task3g3 = task4g1 = task4g2 = task4g3 = task4g4 = task5g1 = task5g2 = task5g3 = task6g1 = task6g2 = task6g3 = task6g4 = freetaskg1 = freetaskg2 = freetaskg3 = false;
        foreach (GameObject task in TaskList)
        {
            task.SetActive(false);
        }
    }
    void TemasToFalse()
    {
        tasktemas = freetasktemas = task1g1temas = task1g2temas = task1g3temas = task2g1temas = task2g2temas = task2g3temas = task2g4temas = task3g1temas = task3g2temas = task3g3temas = task4g1temas = task4g2temas = task4g3temas = task4g4temas = task5g1temas = task5g2temas = task5g3temas = task6g1temas = task6g2temas = task6g3temas = task6g4temas = freetaskg1temas = freetaskg2temas = freetaskg3temas = false;
        TaskText.SetActive(false);
        BottleFeedBack.gameObject.SetActive(false);
        OrangeFeedBack.gameObject.SetActive(false);
        GreenFeedBack.gameObject.SetActive(false);
        RedFeedBack.gameObject.SetActive(false);
        CheeseFeedBack.gameObject.SetActive(false);
    }

    void BottleBuy()
    {
        if (Task1.activeSelf)
        {
            int maliyet = 20;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task1g1 = true;
                task1g1temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g1 altýn yetersiz");
            }
        }
        if (Task2.activeSelf)
        {
            int maliyet = 40;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task2g1 = true;
                task2g1temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g2 altýn yetersiz");
            }
        }
        if (Task3.activeSelf)
        {
            int maliyet = 30;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task3g1 = true;
                task3g1temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g3 altýn yetersiz");
            }
        }
        if (Task4.activeSelf)
        {
            int maliyet = 30;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task4g1 = true;
                task4g1temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g4 altýn yetersiz");
            }
        }
        if (Task5.activeSelf)
        {
            int maliyet = 25;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task5g1 = true;
                task5g1temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g5 altýn yetersiz");
            }
        }
        if (Task6.activeSelf)
        {
            int maliyet = 60;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task6g1 = true;
                task6g1temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g6 altýn yetersiz");
            }
        }
    }

    void CheeseBuy()
    {
        if (Task2.activeSelf)
        {
            int maliyet = 40;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task2g4 = true;
                task2g4temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g2 altýn yetersiz");
            }
        }
        if (Task4.activeSelf)
        {
            int maliyet = 40;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task4g4 = true;
                task4g4temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g4 altýn yetersiz");
            }
        }
        if (Task6.activeSelf)
        {
            int maliyet = 40;
            int güncelaltýn = PlayerPrefs.GetInt("Gold", 0);
            if (güncelaltýn >= maliyet)
            {
                güncelaltýn -= maliyet;
                PlayerPrefs.SetInt("Gold", güncelaltýn);
                UpdateGoldUI(güncelaltýn);
                PlayerPrefs.Save();
                task6g4 = true;
                task6g4temas = false;
                Debug.Log("Item satýn alýndý! Kalan altýn: " + güncelaltýn);
            }
            else
            {
                Debug.Log("g6 altýn yetersiz");
            }
        }
    }
    void UpdateGoldUI(int goldAmount)
    {
        GoldText.text = goldAmount.ToString();
    }
    void UpdateComplatedUI(int Complated)
    {
        ComplatedTask.text = Complated.ToString();
    }
}
