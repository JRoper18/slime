using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class SlimeSettings : ScriptableObject
{
	[Header("Simulation Settings")]
	[Min(1)] public int stepsPerFrame = 1;
	public int width = 1280;
	public int height = 720;
	public int numAgents = 100;
	public Simulation.SpawnMode spawnMode;

	[Header("Trail Settings")]
	public float trailWeight = 1;
	public float decayRate = 1;
	public float diffuseRate = 1;

	[Header("Food Settings")]
	public int brushSize = 1;

	public Color foodColor = Color.green;

	public SpeciesSettings[] speciesSettings;

	[System.Serializable]
	public struct SpeciesSettings
	{
		[Header("Movement Settings")]
		public float moveSpeed;
		public float turnSpeed;
		[Min(0)] public float foodEatRate; // How fast they eat food once over it. 


		[Header("Sensor Settings")]
		public float sensorAngleSpacing;
		public float sensorOffsetDst;
		[Min(1)] public int sensorSize;

		public float foodWeight; // How much they like food > following. 

		[Header("Display settings")]
		public Color colour;

	}
}
