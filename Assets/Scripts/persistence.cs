using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class persistence{
	public void saveScore(int score)
	{
		BinaryFormatter bf = new BinaryFormatter();
		highScore hs = loadScore();
		FileStream file = File.Create(Application.persistentDataPath+"/scores.dat");
		for(int i=0; i<10; i++)
		{
			if((int)hs.scores[i]>score)
			{
			}
			else
			{
				hs.scores.Insert(i, score);
				if(hs.scores.Count>10)
				{
					hs.scores.RemoveAt(10);
				}
				break;
			}
		}
		bf.Serialize(file, hs);
		file.Close();
	}
	
	public highScore loadScore()
	{
		highScore hs;
		if(File.Exists(Application.persistentDataPath+"/scores.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath+"/scores.dat", FileMode.Open);
			hs =(highScore)bf.Deserialize(file);
			file.Close();
		}
		else
		{
			hs = new highScore();
			for(int i = 0;i<10; i++)
			{
				hs.scores.Add(0);
			}
		}
		return(hs);
	}

	public string writeScore()
	{	
		highScore hs = loadScore();
		string scores = "HIGH SCORES\n";
		for(int i = 0; i < hs.scores.Count; i++)
		{
			scores += (i+1) + ". " + (int)hs.scores[i] + "\n";
		}
		return scores;
	}
}
//holds top ten high scores
[Serializable]
public class highScore 
{
	public ArrayList scores = new ArrayList(10);
}
