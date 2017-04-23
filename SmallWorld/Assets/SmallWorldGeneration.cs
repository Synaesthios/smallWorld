using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallWorldGeneration : MonoBehaviour {

	public float temperature;
	public float water_level;
	public float air_quality;
	public int population;
	public int generation_counter;

	Text Val_Temperature;
	Text Val_Water_Level;
	Text Val_Air_Quality;
	Text Val_Population;

	// Use this for initialization
	void Start () {
		temperature = 0.0f;
		water_level = 50.0f;
		air_quality = 100.0f;
		population = 100;
		generation_counter = 0;

		Val_Temperature = GetComponent<Text>();
		Val_Temperature.text = temperature.ToString();
		Val_Water_Level = GetComponent<Text>();
		Val_Water_Level.text = water_level.ToString();
		Val_Air_Quality = GetComponent<Text>();
		Val_Air_Quality.text = air_quality.ToString();
		Val_Population = GetComponent<Text>();
		Val_Population.text = population.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		Val_Temperature.text = temperature.ToString();
		Val_Water_Level.text = water_level.ToString();
		Val_Air_Quality.text = air_quality.ToString();
		Val_Population.text = population.ToString();
	}
}
