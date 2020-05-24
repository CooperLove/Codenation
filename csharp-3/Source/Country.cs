using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Country
    {        
        public State[] Top10StatesByArea()
        {
            List<KeyValuePair<State, float>> states = StatesArea();
            Sort(states);
            State[] s = new State[10];
            for (int i = 0; i < 10; i++)
            {
                s[i] = states[i].Key;
            }
            foreach (KeyValuePair<State, float> item in states)
            {
                //Console.WriteLine($"{item.Key.Name} {item.Key.Acronym} => {item.Value}");
            }
            return s;
        }

        public List<KeyValuePair<State, float>> StatesArea (){
            string[] lines = System.IO.File.ReadAllLines(@"areas.txt");
            List<KeyValuePair<State, float>> statesInfo = new List<KeyValuePair<State, float>>();
            foreach (string info in lines)
            {
                string[] state = info.Split('-');
                State s = new State(state[0], state[1]);
                float area;
                float.TryParse(state[2], out area);
                statesInfo.Add(new KeyValuePair<State, float>(s, area));
                
            }
            foreach (KeyValuePair<State, float> item in statesInfo)
            {
                //Console.WriteLine($"{item.Key.Name} {item.Key.Acronym} => {item.Value}");
            }

            return statesInfo;
        }

        public List<KeyValuePair<State, float>> Sort (List<KeyValuePair<State, float>> list){
            int t = list.Count;
            for (int i = 0; i < t; i++)
            {
                for (int j = i+1; j < t; j++)
                {
                    if (list[i].Value < list[j].Value){
                        KeyValuePair<State, float> temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return null;
        }
    }
}
