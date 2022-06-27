using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;
    
    
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Hi, do you love chemsitry?");
            break;
        case 4:
            print ("What is your opinion on the climate change");
            break;
        case 3:
            print ("Do you want to live in Mars");
            break;
        case 2:
            print ("What do you think about Solar energy");
            break;
        case 1:
            print ("What can I do to save gas");
            break;
        default:
            print ("This level of intelligence is too low");
            break;
        }
    }
}