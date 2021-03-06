﻿using UnityEngine;
/// <summary>
/// 定義怪獸物件
/// </summary>

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪獸的血量
    /// </summary>
    [Header("血量"),Tooltip("怪獸的血量"),Range(50,500)]
    public int HP;
    /// <summary>
    /// 怪獸的魔力
    /// </summary>
    [Header("魔力"),Tooltip("怪獸的魔力"),Range(10,100)]
    public int MP = 100;
    /// <summary>
    /// 怪獸的移動速度
    /// </summary>
    [Header("能力值"),Range(1,50.5f)]
    public float Move_Speed = 10.5f;
    /// <summary>
    /// 怪獸的攻擊力
    /// </summary>
    [Range(20, 200)]
    public int Attack = 50;
    /// <summary>
    /// 怪獸的防禦力
    /// </summary>
    [Range(20, 200)]
    public int Defense;
    /// <summary>
    /// 怪獸的武器名稱 
    /// </summary>
    [Header("裝備")]
    public string Arms;
    /// <summary>
    /// 怪獸的裝備名稱
    /// </summary>
    public string Equip = "皮衣";
    /// <summary>
    /// 怪獸是否有拿鑰匙
    /// </summary>
    [Header("其他資料"), Tooltip("怪獸是否帶有鑰匙")]
    public bool Key = false;
    /// <summary>
    /// 怪獸是否掉落寶物
    /// </summary>
    [Tooltip("怪獸是否帶有寶物")]
    public bool Treasure = false;




}
