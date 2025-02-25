﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   public GameObject[] enemies;
   public GameObject powerup;

   private float zEnemySpawn = 12.0f;
   private float xSpawnRange = 16.0f;
   private float zPowerupRange = 5.0f;
   private float ySpawn = 0.75
   
   // Start is called before the first frame update
   void Start()
   {
       SpawnEnemy();
       SpawnPowerup();
   }

   // Update is called once per frame
   void Update()
   {
   
   }

   void SpawnEnemy()
   {
   float randomX = Random.Range(-xSpawnRange, xSpawnRange);
   int randomIndex = Random.Range(0, enemies.Length);

   Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

   Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
   }

   void SpawnPower()
   {
      float randomX = Random.Range(-xSpawnRange, xSpawnRange);
      float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

      Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

      Instantiate(powerup SpawnPos powerup gameObject transform rotation);
   }
}
