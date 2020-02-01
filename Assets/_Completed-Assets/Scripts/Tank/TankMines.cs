using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMines : MonoBehaviour
{
    public GameObject m_Mine;
    public Transform m_MineTransform;
    public int m_PlayerNumber;
    private string m_MineButton;
    void Update()
    {
        m_MineButton = "Mine" + m_PlayerNumber;
        if (Input.GetButtonDown(m_MineButton))
        {
            GameObject Mine = Instantiate(m_Mine, m_MineTransform.position, m_MineTransform.rotation) as GameObject;
        }
    }
}
